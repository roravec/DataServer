using System;
using ERMA.MMO;

namespace DataServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DataServer v1");
            Configuration.ReadConfig();
            DataServer mainDataServer = new DataServer(Configuration.ConfigurationSetup);
            mainDataServer.Start();
        }
    }
}
