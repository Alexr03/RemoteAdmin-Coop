using Rocket.Core.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace RemoteAdmin
{
    public static class HTTPServer
    {
        private static HttpListener web = new HttpListener();

        public static void startServer()
        {
            web.Prefixes.Add("http://*:" + Main.Instance.Configuration.Instance.Port + "/");
            Logger.Log("Starting to listen at port " + Main.Instance.Configuration.Instance.Port);
            web.Start();
            web.BeginGetContext(new AsyncCallback(callback), web);
        }

        public static void stopServer()
        {
            web.Prefixes.Remove("http://*:" + Main.Instance.Configuration.Instance.Port + "/");
            Logger.Log("Closing listening port: " + Main.Instance.Configuration.Instance.Port);
            web.Stop();
            web.Close();
        }

        private static void callback(IAsyncResult result)
        {
            HttpListener listener = (HttpListener)result.AsyncState;
            HttpListenerContext context = listener.EndGetContext(result);
            web.BeginGetContext(new AsyncCallback(callback), web);
            HttpListenerRequest request = context.Request;

            if (request.RawUrl == "/favicon.ico")
            {
                return;
            }

            HttpListenerResponse response = context.Response;

            var data = new StreamReader(context.Request.InputStream).ReadToEnd();

            string responseString = "<HTML><BODY>Received data</BODY></HTML>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);

            output.Close();
            Main.read_response(data);

        }
    }
}