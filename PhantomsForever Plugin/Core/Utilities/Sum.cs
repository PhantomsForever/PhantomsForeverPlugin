using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhantomsForever_Plugin.Core.Utilities
{
    public class Sum
    {
        public static object Do(object[] arr, int start = 0)
        {
            return arr.Length + start;
        }
        public static string Do(string[] arr, int start = 0)
        {
            return Convert.ToString(arr.Length + start);
        }
    }
}