using System;
using System.Collections.Generic;
using System.Text;

namespace KenzeApplication.ExtensionMethods
{
    public static class ArrayExtension
    {
        public static bool Contains(this string[] stringArray, string word)
        {
            if(Array.IndexOf(stringArray,word) != -1)
            {
                return true;
            }
            return false;
        } 
    }
}
