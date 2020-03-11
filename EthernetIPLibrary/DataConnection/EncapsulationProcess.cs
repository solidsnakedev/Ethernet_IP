using System;
using System.Collections.Generic;
using System.Text;

namespace EthernetIPLibrary.DataConnection
{
    public class EncapsulationProcess
    {
        public byte[] GetBytes(EncapsulationHeaderModel encapsulationHeader, EncapsulationDataModel encapsulationData)
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
