using System;

namespace Archiver.Client.Helpers
{
    public static class DateTimeExtenders
    {
        public static DateTime ToMinuteOn(this DateTime value) =>
            new DateTime(value.Ticks - value.Ticks % TimeSpan.TicksPerMinute);
    }
}
