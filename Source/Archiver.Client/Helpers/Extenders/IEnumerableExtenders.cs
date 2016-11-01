using System.Collections.Generic;
using System.Linq;

namespace Archiver.Client.Helpers
{
    public static partial class Extenders
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> items)=>
            (items == null) || (!items.Any());
    }
}
