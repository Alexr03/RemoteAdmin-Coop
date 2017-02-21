using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SolarRemoteAdminLibary
{
    public class Networking
    {
        public static string Version = "1.0.0";

        public static bool send(string command, string Password, int ServerID)
        {
            string URL = string.Empty;

            switch (ServerID)
            {
                case 1:
                    URL = "http://eu-w101.solarsentinels.co.uk:5000/";
                    break;
                case 2:
                    URL = "http://eu-w101.solarsentinels.co.uk:5001/";
                    break;
                case 5:
                    URL = "http://eu-w101.solarsentinels.co.uk:5002/";
                    break;
                case 6:
                    URL = "http://eu-w101.solarsentinels.co.uk:5005/";
                    break;
                case 7:
                    URL = "http://eu-w101.solarsentinels.co.uk:5004/";
                    break;
                case 8:
                    URL = "http://eu-w101.solarsentinels.co.uk:5003/";
                    break;
            }

            var request = (HttpWebRequest)WebRequest.Create(URL);

            var postData = "command=" + command;
            postData += "&pass=" + Password;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return true;
        }


        public static string GetPasswords()
        {
            WebClient client = new WebClient();

            return client.DownloadString("http://eu-w101.solarsentinels.co.uk/svrLogs/pass.txt");
        }

        public static bool CheckForUpdate()
        {
            WebClient client = new WebClient();
            string newversion = client.DownloadString("http://eu-w101.solarsentinels.co.uk/svrLogs/update.txt");

            if (newversion == Version)
            {
                return false;
            }
            else { return true; }
        }
    }
}
