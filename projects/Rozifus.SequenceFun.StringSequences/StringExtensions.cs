using System;
using Rozifus.SequenceFun.Interfaces;

namespace Rozifus.SequenceFun.StringExtensions {
    public static class StringExtensions
    {
        public static string ReplaceCharAt(this string original, int index, char newChar) {
            if (original == null)
            {
                throw new ArgumentNullException("input");
            }

            if (index < 0 || index >= original.Length) {
                throw new ArgumentOutOfRangeException($"No char at index {index} in string \"{original}\"");
            }

            char[] chars = original.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }
    }
}
