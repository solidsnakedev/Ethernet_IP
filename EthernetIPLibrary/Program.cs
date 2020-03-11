using System;

namespace EthernetIPLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            PLCModel ControlLogix = new PLCModel("172.24.8.125","CPU");
            PLCConnection connection = new PLCConnection(ControlLogix);
            connection.ConnectToPLC();
            
            Console.ReadLine();
        }
    }
}
