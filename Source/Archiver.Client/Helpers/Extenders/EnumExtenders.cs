using System;
using System.Diagnostics;

namespace Archiver.Client.Helpers
{
    public static class EnumExtenders
    {
        [DebuggerHidden]
        public static T ToEnum<T>(this string value) where T : struct
        {
            if (typeof(T).BaseType != typeof(Enum))
                throw new ArgumentException($"{typeof(T)} is not an Enum!");

            if (!value.IsTrimmed())
                throw new ArgumentOutOfRangeException(nameof(value));

            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
