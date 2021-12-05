using ERMA.MMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer
{
    public class DataClientSandbox : Sandbox
    {
        public DataClientSandbox(PacketActionDictionary dictionary) : base(dictionary, typeof(DataClientSandbox))
        {

        }
    }
}
