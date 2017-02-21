using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteAdmin
{
    public class CommandRepass : IRocketCommand
    {
        public string Help
        {
            get { return ""; }
        }

        public string Name
        {
            get { return "repass"; }
        }

        public string Syntax
        {
            get { return ""; }
        }

        public List<string> Aliases
        {
            get { return new List<string>(); }
        }

        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Both; }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "Remote.RePass" };
            }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            Main.Passwords.Clear();

            Main.GetPasswords();
        }
    }
}