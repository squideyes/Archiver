using System;
using System.Collections;
using System.Collections.Generic;

namespace Archiver.Client.Helpers
{
    public abstract class ListBase<T> : IEnumerable<T>
    {
        public ListBase()
        {
            Items = new List<T>();
        }

        protected List<T> Items { get; }

        public int Count => Items.Count;

        public T this[int index] => Items[index];

        public void Sort() => Items.Sort();

        public void ForEach(Action<T> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            Items.ForEach(action);
        }

        public IEnumerator<T> GetEnumerator() => Items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
