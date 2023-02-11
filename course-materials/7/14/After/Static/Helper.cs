using System;

namespace Helpers
{
    public static class StringHelper
    {
        public static string ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Invalid string");
            }
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        
    }
    
}