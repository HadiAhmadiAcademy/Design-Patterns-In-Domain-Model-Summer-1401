using System;

namespace CompositeSpecificationDemo
{
    public static class StringExtensions
    {
        public static string ReplaceFirst(this string text, string replace, string with)
        {
            var indexOfReplace = text.IndexOf(replace, StringComparison.Ordinal);
            return text.Substring(0, indexOfReplace) 
                   + with 
                   + text.Substring(indexOfReplace + replace.Length);
        }
    }
}