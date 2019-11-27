using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JobTaskSecond.WebUI.Core
{
    public class Tools
    {
        public static string ReverseString(string name)
        {
            char[] array = name.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        public static void SaveReverseString(string [] name)
        {
            File.WriteAllLines("out.txt", name);
        }
    }
}
