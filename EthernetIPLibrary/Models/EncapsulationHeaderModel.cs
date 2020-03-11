using System;
using System.Collections.Generic;
using System.Text;

namespace EthernetIPLibrary
{
    public class EncapsulationHeaderModel
    {
        /// <summary>
        /// Encapsulation Header
        /// EtherNet/IP Adaptation of CIP Specification
        /// http://read.pudn.com/downloads166/ebook/763212/EIP-CIP-V2-1.0.pdf
        /// Table 2-4.1 – Encapsulation packet
        /// </summary>
        public ushort EIPCommand { get; set; }
        public ushort EIPLength { get; set; }
        public uint EIPSessionHandle { get; set; }
        public uint EIPStatus { get; set; }
        public ulong EIPContext { get; set; }
        public uint EIPOptions { get; set; }


        public EncapsulationHeaderModel(ushort EIPCommand, ushort EIPLength, uint EIPSessionHandle, uint EIPStatus, ulong EIPContext, uint EIPOptions)
        {
            this.EIPCommand = EIPCommand;
            this.EIPLength = EIPLength;
            this.EIPSessionHandle = EIPSessionHandle;
            this.EIPStatus = EIPStatus;
            this.EIPContext = EIPContext;
            this.EIPOptions = EIPOptions;
        }

           
       


    }
}
