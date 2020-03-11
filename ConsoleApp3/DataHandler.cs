using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace ConsoleApp3
{
    class DataHandler
    {
        bool isConnected;
        public DataHandler()
        {

        }
        public void ReadTag(Tag Tag)
        {

            
            if (isConnected == false )
            {
                isConnected=ConnectToPLC(Tag.plc.IPAddress, Tag.plc.PortNumber);
            }

            //byte[] ParsedTagArray = ParseTag(Tag.TagName);
            //int count = 0;
            //foreach (var item in ParsedTagArray)
            //{
            //    Console.WriteLine("Byte Array {0}, {1}", count++, item);
            //}
            //Console.ReadLine();
            //SendPackage(ParsedTagArray, Tag.plc.IPAddress, Tag.plc.PortNumber);

        }

        public byte[] ParseTag(string TagName)
        {
            byte[] EncodedTagArray = Encoding.ASCII.GetBytes(TagName);
            //this.BaseTag = TagName;
            return EncodedTagArray;
        }

        public void SendPackage(byte[] Data, String IPAddress, int PortNumber)
        {
            TcpClient TCPTest = new TcpClient(IPAddress, PortNumber);
            Console.WriteLine("TCP Created");
            NetworkStream stream = TCPTest.GetStream();
            Console.WriteLine("Get Stream");
            stream.Write(Data, 0, Data.Length);
            Console.WriteLine("Message Sent");

            stream.Close();
            TCPTest.Close();

        }

        public bool ConnectToPLC(String IPAddress, int PortNumber)
        {

            //Encapsulation encapsulation = new Encapsulation();


            TcpClient TCPTest = new TcpClient(IPAddress, PortNumber);
            NetworkStream stream = TCPTest.GetStream();

            //EIPCommand = 0x0065
            //EIPLength = 0x0004
            //EIPSessionHandle = self.SessionHandle
            //EIPStatus = 0x0000
            //EIPContext = self.Context
            //EIPOptions = 0x0000
           

            return true;
        }
    }
}
