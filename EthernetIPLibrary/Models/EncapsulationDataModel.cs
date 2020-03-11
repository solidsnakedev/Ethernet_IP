using System;
using System.Collections.Generic;
using System.Text;

namespace EthernetIPLibrary
{
    public class EncapsulationDataModel
    {
        /// <summary>
        /// Encapsulation Data
        /// EtherNet/IP Adaptation of CIP Specification
        /// http://read.pudn.com/downloads166/ebook/763212/EIP-CIP-V2-1.0.pdf
        /// Table 2-4.1 – Encapsulation packet
        /// </summary>
        public ushort ProtocolVersion { get; set; }
        public ushort OptionsFlags { get; set; }
        public EncapsulationDataModel(ushort ProtocolVersion, ushort OptionsFlags)
        {
            this.ProtocolVersion = ProtocolVersion;
            this.OptionsFlags = OptionsFlags;
        }
    }
}
