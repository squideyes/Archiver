using System.Configuration;

namespace Archiver.Client.Config
{
    public class ConfigStringElement : ConfigurationElement
    {
        public ConfigStringElement()
        {
        }

        public ConfigStringElement(string name, string connString)
        {
            Name = name;
            ConnString = connString;
        }

        [ConfigurationProperty("Name", DefaultValue = "",
            IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)this["Name"]; }
            set { this["Name"] = value; }
        }

        [ConfigurationProperty("ConnString", DefaultValue = "",
            IsRequired = true, IsKey = false)]
        public string ConnString
        {
            get { return (string)this["ConnString"]; }
            set { this["ConnString"] = value; }
        }
    }
}
