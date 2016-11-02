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

            foreach (ConnStringElement cs in section.ConnStrings)
                Accounts.Add(cs.Name, cs.ConnString);
        }

        public static Dictionary<string, string> Accounts { get; } = 
            new Dictionary<string, string>();
    }
}
