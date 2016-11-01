using System.Configuration;

namespace Archiver.Client.Config
{
    public class ConfigStringCollection : ConfigurationElementCollection
    {
        public ConfigStringElement this[int index]
        {
            get
            {
                return (ConfigStringElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);

                BaseAdd(index, value);
            }
        }

        public void Add(ConfigStringElement serviceConfig) => 
            BaseAdd(serviceConfig);

        public void Clear() => BaseClear();

        protected override ConfigurationElement CreateNewElement() =>
            new ConfigStringElement();

        protected override object GetElementKey(ConfigurationElement element) =>
            ((ConfigStringElement)element).Name;

        public void Remove(ConfigStringElement element) =>
            BaseRemove(element.Name);

        public void RemoveAt(int index) => BaseRemoveAt(index);

        public void Remove(string name) => BaseRemove(name);
    }
}
