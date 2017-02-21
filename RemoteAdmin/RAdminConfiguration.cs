using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteAdmin
{
    public class RAdminConfiguration : IRocketPluginConfiguration
    {
        public string Port;

        public void LoadDefaults()
        {
            Port = "5000";
        }
    }
}
