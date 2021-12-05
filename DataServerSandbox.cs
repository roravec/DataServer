using Connectivity;
using ERMA.MMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataServer
{
    public class DataServerSandbox : ERMA.MMO.Sandbox
    {
        public DataServerSandbox(ConfigSet configuration, PacketActionDictionary packetFunctionDictionary) : 
            base(packetFunctionDictionary, typeof(DataServerSandbox))
        {
            PacketActionDictionary newDictionary = new PacketActionDictionary(0, null);
            PacketActionsDictionary = newDictionary;

            PacketAction pf1 = new PacketAction();
            pf1.PacketID = 7;
            pf1.Name = "FGetDBData";
            pf1.NumberOfParameters = 2;
            PacketAction pf2 = new PacketAction();
            pf2.PacketID = 8;
            pf2.Name = "FTestFunction";
            pf2.NumberOfParameters = 4;
            PacketActionsDictionary.AddNewAction(pf1);
            PacketActionsDictionary.AddNewAction(pf2);
        }

        public void FGetDBData(PacketData par1)
        {
            Console.WriteLine("CLIENT METHOD:FGetDBData | "+par1);
        }
        protected void FTestFunction(string par1, string par2, string par3, string par4)
        {
            Console.WriteLine("CLIENT METHOD:FGetDBData | " + par1 + " " + par2 + " " + par3 + " " + par4);
        }
    }
}
