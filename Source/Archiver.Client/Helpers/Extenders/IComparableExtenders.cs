using System;

namespace Archiver.Client.Helpers
{
    public static class IComparableExtenders
    {
        public static bool InRange<T>(this T value, T minValue, T maxValue) 
            where T : IComparable<T>
        {
            return (value.CompareTo(minValue) >= 0) && (value.CompareTo(maxValue) <= 0);
        }
    }
}
