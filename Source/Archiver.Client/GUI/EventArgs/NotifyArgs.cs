using System;

namespace Archiver.Client
{
    public class NotifyArgs : EventArgs
    {
    }

    public class NotifyArgs<T> : NotifyArgs
    {
        public NotifyArgs(T data)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
