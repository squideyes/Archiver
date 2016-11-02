using System.Configuration;

namespace Archiver.Client.Config
{
    public class SettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("ConnStrings", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ConnStringCollection),
            AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
        public ConnStringCollection ConnStrings => 
            (ConnStringCollection)base["ConnStrings"];
    }
}
