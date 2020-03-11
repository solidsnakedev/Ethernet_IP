using System;
using System.Collections.Generic;
using System.Text;

namespace EthernetIPLibrary
{
    class PLCConnection
    {
        public PLCModel PLCModel;
        public PLCConnection(PLCModel PLCModel)
        {
            this.PLCModel = PLCModel;
        }

        public void ConnectToPLC()
        {
            EncapsulationPacket encapsulationPacket = new EncapsulationPacket();
            encapsulationPacket.RegisterSessionRequest(PLCModel);
        }
    }
}
