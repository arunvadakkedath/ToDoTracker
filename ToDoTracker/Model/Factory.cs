using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTracker
{
    public class Factory
    {
        private static Factory FactoryObj = null;
        private Factory() { }

        public static Factory GetObj()
        {
            if (FactoryObj == null)
                FactoryObj = new Factory();
            return FactoryObj;
        }

        public IToDo ToDoObj()
        {
            return new ToDo();
        }
    }
}
