using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp3
{

    class Program
    {
        private const int portNum = 13;
        private const string hostName = "192.168.0.50";
        static void Main(string[] args)
        {
            PLC NewPLC = new PLC("192.168.0.50", 2, 44818, 0);
            Tag TagTest = new Tag(NewPLC, "TEST", "DINT");


            var GetData = new DataHandler();
            GetData.ReadTag(TagTest);



        }

        public void TestPLC()
        {
            

        }
    }
    
}
