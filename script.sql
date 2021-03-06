USE [MUCTEST]
GO
/****** Object:  Table [dbo].[Tbl_TODOList]    Script Date: 5/11/2021 4:16:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_TODOList](
	[SNo] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Description] [varchar](max) NULL,
	[DueDate] [varchar](100) NULL,
	[Status] [varchar](20) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedOn] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Proc_ToDo]    Script Date: 5/11/2021 4:17:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Proc_ToDo]
	@P_Condition		varchar(50),
	@P_SNo				int				= NULL,
	@P_Title			varchar(Max)	= NULL,
	@P_Description		varchar(Max)	= NULL,
	@P_DueDate			varchar(Max)	= NULL,
	@P_Status			varchar(20)		= NULL,
	@P_CreatedBy		varchar(50)		= NULL,
	@P_ProcMessage		varchar(Max)	= NULL OutPut,
	@P_ProcReturn		Integer 		= NULL OutPut
AS
Begin Transaction
Declare @RetryCounter INT
Set @RetryCounter = 1
Retry:
Begin Transaction
Begin Try
	Set NoCount On
	Set @P_ProcMessage='Operation Failed.'
	Set @P_ProcReturn=0

	Declare
	@Sql as varchar(100)=''
	/*
	Exec Proc_ToDo @P_Condition='AddUpdateToDo',@P_SNo=1,@P_Title='run async',@P_Description='abcdefdi',@P_DueDate='2021-05-11',
				   @P_Status='Not Started',@P_CreatedBy=1
	*/
	if @P_Condition='AddUpdateToDo'
	Begin
		If ISNULL(@P_SNo,0)<>0
		Begin
			Select @Sql = Status from Tbl_TODOList where SNo=@P_SNo
			If (Upper(ISNULL(@Sql,''))='COMPLETED') or (CONVERT(Date, @P_DueDate) < CONVERT(Date, GetDate()))
			Begin
				Set @P_ProcMessage='Unable to update.Please check status or due date..!' 
				Set @P_ProcReturn=1
			End
			Else
			Begin
				Update Tbl_TODOList set Title=@P_Title,Description=@P_Description,DueDate=@P_DueDate,Status=@P_Status,ModifiedBy=@P_CreatedBy,
				ModifiedOn=GetDate()
				where SNo=@P_SNo

				Set @P_ProcMessage=Cast(@@RowCount as varchar) + ' Record(s) Updated' 
				Set @P_ProcReturn=1
			End
		End
		Else
		Begin
			Insert into Tbl_TODOList( Title,Description,DueDate,Status,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn)
			Select @P_Title,@P_Description,@P_DueDate,@P_Status,@P_CreatedBy,GetDate(),@P_CreatedBy,GetDate()

			Set @P_ProcMessage=Cast(@@RowCount as varchar) + ' Record(s) Inserted' 
			Set @P_ProcReturn=1
		End
	End

	if @P_Condition='DeleteToDo'
	Begin
		If ISNULL(@P_SNo,0)<>0
		Begin
			Delete from Tbl_TODOList where SNo=@P_SNo

			Set @P_ProcMessage=Cast(@@RowCount as varchar) + ' Record(s) Deleted' 
			Set @P_ProcReturn=1
		End
		Else
		Begin
			Set @P_ProcMessage='Unable to delete' 
			Set @P_ProcReturn=1
		End
	End


	if @P_Condition='ShowToDo'
	Begin
		Select top 100 SNo,Title,Description,DueDate,Status,ModifiedOn from Tbl_TODOList(NoLock)
		where Upper(ISNULL(Status,''))<>'COMPLETED'
		order by ModifiedOn 

		Set @P_ProcMessage=Cast(@@RowCount as varchar) + ' Record(s) Selected' 
		Set @P_ProcReturn=1
	End

	if @P_Condition='ReadAllToDo'
	Begin
		Select top 1000 SNo,Title,Description,DueDate,Status,ModifiedOn from Tbl_TODOList(NoLock)
		order by ModifiedOn 

		Set @P_ProcMessage=Cast(@@RowCount as varchar) + ' Record(s) Selected' 
		Set @P_ProcReturn=1
	End


	  			
	Commit Transaction
	Set NoCount Off
End Try
Begin Catch
	RollBack Transaction
	Declare @DoRetry bit;
	Declare @ErrorMessage varchar(Max)
	Set @doRetry = 0;
	Set @ErrorMessage = Error_Message()
	If Error_Message() = 1205 -- Deadlock Error Number
	Begin
		Set @doRetry = 1;
	End
	If @DoRetry = 1
	Begin
		Set @RetryCounter = @RetryCounter + 1
		If (@RetryCounter > 5)				
		Begin
			RaisError(@ErrorMessage, 18, 1) -- Raise Error Message if still deadlock occurred after three retries
		End
		Else
		Begin
			WaitFor Delay '00:00:00.500' -- Wait for 100 ms
			GoTo Retry	-- Go to Label RETRY
		End
	End
	Else
	Begin
		RaisError(@ErrorMessage,18, 1)
	End
End Catch
    
IF(@@Error<>0)
Begin
	Set @P_ProcReturn=0
	Set @P_ProcMessage=ERROR_MESSAGE()
	RollBack
End
Else
Begin
	Commit
	Return (1) 
End

if @P_ProcMessage=''
Begin 
	Set @P_ProcMessage=ERROR_MESSAGE()
End
GO
