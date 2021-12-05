using Connectivity;
using DatabaseConnector;
using ERMA.MMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataServer
{
    /// <summary>
    /// Data server class
    /// </summary>
    public class DataServer
    {
        protected ConfigSet ConfigurationSetup;
        protected Sandbox MainSandbox;
        protected DatabaseConnector.DatabaseConnector dbConn = new DatabaseConnector.DatabaseConnector("");

        public DataServer(ConfigSet configuration)
        {
            ConfigurationSetup = configuration;
            PacketActionDictionary packetFunctionsDisct = new PacketActionDictionary(0, dbConn);
            MainSandbox = new DataServerSandbox(ConfigurationSetup, packetFunctionsDisct);
            MainSandbox.CreateDBConnection(ConfigurationSetup.DBServer, ConfigurationSetup.DBLogin, ConfigurationSetup.DBPassword, ConfigurationSetup.DBDatabase);
            MainSandbox.CreateServer(1215);
            Console.WriteLine("MainSandbox initialized");
        }

        public void Start()
        {
            Console.WriteLine("MainSandbox is going to start...");
            MainSandbox.Start();
            Console.WriteLine("MainSandbox has started.");
            Thread.Sleep(1000);
            var client = MainSandbox.CreateClient("127.0.0.1", 1215);
            client.Connect();
            Thread.Sleep(1000);
            Console.WriteLine("Client Connection status: "+client.GetConnectionStatus());
            Packet newPacket = Packets.PacketSUnitDisappers(38, 2);
            client.Send(newPacket);
        }
        public void Stop()
        {
            MainSandbox.Stop();
        }
    }
}
