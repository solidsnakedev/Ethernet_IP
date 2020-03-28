using System;
using System.Collections.Generic;
using System.Text;

namespace EthernetIPLibrary.DataConnection
{
    public class ConnectionManager
    {
            public PLCModel PLCModel { get; set; }

            public ConnectionManager(PLCModel PLCModel)
            {
                this.PLCModel = PLCModel;
                ConnectToPLC();
            }

            public void ConnectToPLC()
            {
                SessionManager encapsulationManager = new SessionManager();
                encapsulationManager.RegisterSessionRequest(PLCModel);
            }
        
    }
}
