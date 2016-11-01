using Archiver.Client.Config;
using System.Collections.Generic;
using System.Configuration;

namespace Archiver.Client.Consts
{
    public static class WellKnown
    {
        static WellKnown()
        {
            var section = ConfigurationManager
                .GetSection("Settings") as SettingsSection;

            foreach (ConfigStringElement config in section.ConfigStrings)
                Storages.Add(config.Name, config.ConnString);
        }

        public static Dictionary<string, string> Storages { get; } = 
            new Dictionary<string, string>();
    }
}
