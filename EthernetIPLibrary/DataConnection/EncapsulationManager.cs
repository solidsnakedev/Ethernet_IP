using System;
using System.Collections.Generic;
using System.Text;

namespace EthernetIPLibrary.DataConnection
{
    class EncapsulationManager
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

        public byte[] buildRegisterSession()
        {

            EncapsulationHeaderModel encapsulationHeader = new EncapsulationHeaderModel(RegisterSession, 0x0004, 0x00, 0x00, 0x00, 0x00);
            CommandSpecificDataModel encapsulationData = new CommandSpecificDataModel(0x01, 0x00);
            return GetBytes(encapsulationHeader,encapsulationData);

        }

        public byte[] GetBytes(EncapsulationHeaderModel encapsulationHeader, CommandSpecificDataModel encapsulationData)
        {
            List<byte> Data = new List<byte>();
            //Convert every EncapsulationHeader value into byte array then Add then to a Data List
            byte[] encapsulationbyteArray = BitConverter.GetBytes(encapsulationHeader.EIPCommand);
            foreach (var item in encapsulationbyteArray)
            {
                Data.Add(item);
            }
            encapsulationbyteArray = BitConverter.GetBytes(encapsulationHeader.EIPLength);
            foreach (var item in encapsulationbyteArray)
            {
                Data.Add(item);
            }
            encapsulationbyteArray = BitConverter.GetBytes(encapsulationHeader.EIPSessionHandle);
            foreach (var item in encapsulationbyteArray)
            {
                Data.Add(item);
            }

            encapsulationbyteArray = BitConverter.GetBytes(encapsulationHeader.EIPStatus);
            foreach (var item in encapsulationbyteArray)
            {
                Data.Add(item);
            }
            encapsulationbyteArray = BitConverter.GetBytes(encapsulationHeader.EIPContext);
            foreach (var item in encapsulationbyteArray)
            {
                Data.Add(item);
            }
            encapsulationbyteArray = BitConverter.GetBytes(encapsulationHeader.EIPOptions);
            foreach (var item in encapsulationbyteArray)
            {
                Data.Add(item);
            }

            //Convert every EncapsulationData value into byte array then Add then to a Data List
            encapsulationbyteArray = BitConverter.GetBytes(encapsulationData.ProtocolVersion);
            foreach (var item in encapsulationbyteArray)
            {
                Data.Add(item);
            }
            encapsulationbyteArray = BitConverter.GetBytes(encapsulationData.OptionsFlags);
            foreach (var item in encapsulationbyteArray)
            {
                Data.Add(item);
            }

            // Convert Data list to Array so it can be used in TCP Strem
            byte[] Output = Data.ToArray();
            return Output;
        }

    }
}
