using System;
using System.Net;
using System.Net.Sockets;

namespace ConnectToWebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TcpClient();

            const int MAXBUF = 4096;
            const string IP = "127.0.0.1";
            const int PORT = 8080;

            Console.WriteLine("Client Started");
            IPAddress addr = IPAddress.Parse(IP);
            client.Connect(addr, PORT);
            var stream = client.GetStream();








        }
    }
}
