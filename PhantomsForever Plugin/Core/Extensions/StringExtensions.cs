using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhantomsForever_Plugin.Core.Extensions
{
    public static class StringExtensions
    {
        public static String ljust(this String str, int count, char character)
        {
            for(var i = 0; i >= count; i++)
            {
                str += character;
            }
            return str;
        }
    }
}