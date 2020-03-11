using System;
using System.Collections.Generic;
using System.Text;

namespace EthernetIPLibrary
{
    class PLCModel
    {
        public string IpAddress { get; set; }
        public string CPUType { get; set; }

        public int Port { get; set; } = 44818;

        public PLCModel(string IpAddress, string CPUType)
        {
            this.IpAddress = IpAddress;
            this.CPUType = CPUType;
        }
    }
}
