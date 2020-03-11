using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Encapsulation
    {
        
        public ushort EIPCommand { get; set; }
        public ushort EIPLength { get; set; }
        public uint EIPSessionHandle { get; set; }
        public uint EIPStatus { get; set; }

        public ulong EIPContext { get; set; }
        public uint EIPOptions { get; set; }


        public Encapsulation(ushort EIPCommand,ushort EIPLength,uint EIPSessionHandle,uint EIPStatus,ulong EIPContext,uint EIPOptions)
        {
            this.EIPCommand = EIPCommand;//0x0065
            this.EIPLength = EIPLength;//0x0004
            this.EIPSessionHandle = EIPSessionHandle;//self.SessionHandle
            this.EIPStatus = EIPStatus;//0x0000
            this.EIPContext = EIPContext; //self.Context
            this.EIPOptions = EIPOptions; //0x0000
        }



    }
}
