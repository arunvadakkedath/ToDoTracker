using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTracker
{
    public static class EncDec
    {
        public static string Encrypt(string DecryptedString)
        {
            try
            {
                if (DecryptedString == "" || DecryptedString == null)
                    return "";
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
                string key = "NEMSKEY";
                DES.Key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
                DES.Mode = CipherMode.ECB;
                byte[] Buffer = ASCIIEncoding.ASCII.GetBytes(DecryptedString);
                return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Decrypt(string EncryptedString)
        {
            try
            {
                if (EncryptedString == "" || EncryptedString == null)
                    return "";
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
                string key = "NEMSKEY";
                DES.Key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
                DES.Mode = CipherMode.ECB;
                byte[] Buffer = Convert.FromBase64String(EncryptedString);
                return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string LocalEnc(string Ch)
        {
            switch (Ch)
            {
                case "A": return ("!");
                case "B": return ("c");
                case "C": return ("b");
                case "D": return ("y");
                case "E": return ("T");
                case "F": return ("(");
                case "G": return ("0");
                case "H": return ("P");
                case "I": return ("r");
                case "J": return ("B");
                case "K": return ("d");
                case "L": return ("u");
                case "M": return ("5");
                case "N": return ("v");
                case "O": return ("m");
                case "P": return ("#");
                case "Q": return ("Y");
                case "R": return ("g");
                case "S": return ("q");
                case "T": return ("k");
                case "U": return ("8");
                case "V": return ("C");
                case "W": return ("*");
                case "X": return ("1");
                case "Y": return ("o");
                case "Z": return ("A");
                case "a": return ("G");
                case "b": return ("9");
                case "c": return ("%");
                case "d": return ("4");
                case "e": return ("R");
                case "f": return ("j");
                case "g": return ("&");
                case "h": return ("E");
                case "i": return ("F");
                case "j": return ("D");
                case "k": return ("_");
                case "l": return ("N");
                case "m": return ("W");
                case "n": return ("^");
                case "o": return ("<");
                case "p": return ("Z");
                case "q": return ("2");
                case "r": return ("L");
                case "s": return ("Q");
                case "t": return ("w");
                case "u": return ("z");
                case "v": return ("a");
                case "w": return ("t");
                case "x": return ("V");
                case "y": return ("U");
                case "z": return (">");
                case "1": return ("O");
                case "2": return ("M");
                case "3": return ("i");
                case "4": return ("x");
                case "5": return ("@");
                case "6": return ("3");
                case "7": return ("6");
                case "8": return ("I");
                case "9": return ("s");
                case "0": return ("H");
                case "!": return ("7");
                case "@": return ("f");
                case "#": return ("$");
                case "$": return ("S");
                case "%": return ("X");
                case "^": return ("l");
                case "&": return ("J");
                case "*": return ("K");
                case "(": return ("p");
                case ")": return ("h");
                case "_": return ("-");
                case "<": return ("n");
                case ">": return ("e");
                case "-": return (")");
                default:
                    return ("~");
            }
        }
    }
}
