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
        public DataServerSandbox(ConfigSet configuration, PacketFunctionDictionaryType packetFunctionDictionaryType) : 
            base(configuration, packetFunctionDictionaryType, typeof(DataServerSandbox))
        {
            PacketFunctionsDictionary newDictionary = new PacketFunctionsDictionary(packetFunctionDictionaryType, null);
            PacketFunctionsDictionary = newDictionary;

            PacketFunction pf1 = new PacketFunction();
            pf1.PacketID = 7;
            pf1.Name = "FGetDBData";
            pf1.NumberOfParameters = 2;
            PacketFunction pf2 = new PacketFunction();
            pf2.PacketID = 8;
            pf2.Name = "FTestFunction";
            pf2.NumberOfParameters = 4;
            PacketFunctionsDictionary.AddNewFunction(pf1);
            PacketFunctionsDictionary.AddNewFunction(pf2);
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
