using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Archiver.Client.Helpers
{
    public static class StringExtenders
    {
        private static Dictionary<int, Regex> regexes =
            new Dictionary<int, Regex>();

        [DebuggerHidden]
        public static bool IsTrimmed(this string value) => value.IsTrimmed(false);

        [DebuggerHidden]
        public static bool IsTrimmed(this string value, bool emptyOk)
        {
            if (value == (string)null)
                return false;

            if (value == string.Empty)
                return emptyOk;

            return (!char.IsWhiteSpace(value[0]) &&
                (!char.IsWhiteSpace(value[value.Length - 1])));
        }

        [DebuggerHidden]
        public static bool IsFileName(this string value, bool mustBeRooted = true)
        {
            if (!value.IsTrimmed())
                throw new ArgumentOutOfRangeException(nameof(value));

            try
            {
                new FileInfo(value);

                if (!mustBeRooted)
                    return true;
                else
                    return Path.IsPathRooted(value);
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (PathTooLongException)
            {
                return false;
            }
            catch (NotSupportedException)
            {
                return false;
            }
        }
    }
}