using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using EthernetIPLibrary.DataConnection;

namespace EthernetIPLibrary
{

    class EncapsulationPacket 
    {
        /// <summary>
        /// List of CIP Commands
        /// </summary>
        /// Register Session command in hex 0x0065
        public ushort RegisterSession { get; set; } = 0x0065;
        /// <summary>
        /// UnRegisterSession Command in hex 0x0066
        /// </summary>
        public ushort UnRegisterSession { get; set; } = 0x0066;

        /// <summary>
        /// Register Session Request Method
        /// </summary>
        /// 

        /// TODO
        /// Create a list of all the commands listed here http://read.pudn.com/downloads166/ebook/763212/EIP-CIP-V2-1.0.pdf
        /// 2-4.2 Command field
        /// 

        public void RegisterSessionRequest(PLCModel PLC)
        {
            EncapsulationHeaderModel encapsulationHeader = new EncapsulationHeaderModel(RegisterSession,0x0004, 0x00, 0x00, 0x00, 0x00);
            EncapsulationDataModel encapsulationData = new EncapsulationDataModel(0x01, 0x00);
            EncapsulationProcess encapsulationProcess = new EncapsulationProcess();

            // Convert Data list to Array so it can be used in TCP Strem
            byte [] Output = encapsulationProcess.GetBytes(encapsulationHeader, encapsulationData);

            //TCP Connection
            try
            {
                TcpClient client = new TcpClient(PLC.IpAddress, PLC.Port);
                NetworkStream stream = client.GetStream();
                stream.Write(Output, 0, Output.Length);
                Console.WriteLine("Sent: {0}", Output);
                // Buffer to store the response bytes.
                byte[] ReceivedData = new Byte[256];

                // String to store the response ASCII representation.
                String ReceivedDataString = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 ReceivedDatabytes = stream.Read(ReceivedData, 0, ReceivedData.Length);
                ReceivedDataString = System.Text.Encoding.ASCII.GetString(ReceivedData, 0, ReceivedDatabytes);
                Console.WriteLine("Received: {0}", ReceivedDataString);

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }



        }
        public void UnRegisterSessionRequest()
        {
            EncapsulationHeaderModel encapsulation = new EncapsulationHeaderModel(UnRegisterSession, 0x0004, 0x00, 0x00, 0x00, 0x00);

        }


    }
}
