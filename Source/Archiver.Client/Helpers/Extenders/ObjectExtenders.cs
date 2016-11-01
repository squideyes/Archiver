using System.Diagnostics;
using System.Linq;

namespace Archiver.Client.Helpers
{
    public static class ObjectExtenders
    {
        [DebuggerHidden]
        public static bool IsDefault<T>(this T value) =>
            (Equals(value, default(T)));

        [DebuggerHidden]
        public static bool IsAny<T>(this T value, params T[] values) =>
            values.Contains(value);
    }
}
