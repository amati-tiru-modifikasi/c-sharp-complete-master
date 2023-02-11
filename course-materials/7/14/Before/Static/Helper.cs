using System;

namespace Helpers
{
    public class StringHelper
    {
        public string ReverseString(string str)
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