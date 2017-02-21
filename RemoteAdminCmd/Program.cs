using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace RemoteAdminCmd
{
    class Program
    {
        public static List<string> Passwords = new List<string>();

        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("http://eu-w101.solarsentinels.co.uk/svrLogs/pass.txt");

            Passwords.Add(downloadString.ToLower());

            foreach (string v in Passwords)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();
        }
    }
}
