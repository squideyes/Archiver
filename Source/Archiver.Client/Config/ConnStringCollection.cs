using System.Configuration;

namespace Archiver.Client.Config
{
    public class ConnStringCollection : ConfigurationElementCollection
    {
        public ConnStringElement this[int index]
        {
            get
            {
                return (ConnStringElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);

                BaseAdd(index, value);
            }
        }

        public void Add(ConnStringElement element) => BaseAdd(element);

        public void Clear() => BaseClear();

        protected override ConfigurationElement CreateNewElement() =>
            new ConnStringElement();

        protected override object GetElementKey(ConfigurationElement element) =>
            ((ConnStringElement)element).Name;

        public void Remove(ConnStringElement element) =>
            BaseRemove(element.Name);

        public void RemoveAt(int index) => BaseRemoveAt(index);

        public void Remove(string name) => BaseRemove(name);
    }
}
