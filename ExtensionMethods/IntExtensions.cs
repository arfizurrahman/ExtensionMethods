using System;

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        //The first parameter specifies the type on which the extension method is applicable.
        public static bool IsGreaterThan(this int i, int value) 
        {
            return i > value;
        }
    }
    
}
