using System;
using System.Text;
using System.Net.Sockets;

namespace ConsoleApp3
{
    public class PLC
    {
        public String IPAddress;
        public int SlotNumber;
        public int PortNumber;
        public int VendorID;

        public PLC(string IpAddress, int SlotNumber, int PortNumber, int VendorId)
        {
            this.IPAddress = IpAddress;
            this.SlotNumber = SlotNumber;
            this.PortNumber = PortNumber;
            this.VendorID = VendorId;
        }
      

    }
}
