using System;
using System.Diagnostics;

namespace Archiver.Client.Helpers
{
    public static class OperatorExtenders
    {
        [DebuggerHidden]
        public static bool IsGreaterThanOrEqualTo<T>(this T value, T minValue)
            where T : IComparable<T>
        {
            if (!(value is ValueType) && (value == null))
                return false;

            return (value.CompareTo(minValue) >= 0);
        }
    }
}