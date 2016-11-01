namespace Archiver.Client.Helpers
{
    public class GenericArgs<T>
    {
        public GenericArgs(T data)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
