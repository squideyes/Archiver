using System.Configuration;

namespace Archiver.Client.Config
{
    public class SettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("ConfigStrings", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ConfigStringCollection),
            AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
        public ConfigStringCollection ConfigStrings => 
            (ConfigStringCollection)base["ConfigStrings"];
    }
}
