using System;

namespace MyApi.Extensions
{
    public static class StringExtensions
    {
        public static string CapitalizeFirstLetter(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            return char.ToUpper(value[0]) + value.Substring(1);
        }
    }
}
