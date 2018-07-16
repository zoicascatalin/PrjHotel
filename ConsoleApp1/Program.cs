using System;
using System.IO.Ports;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            SerialPort sp = new SerialPort("COM3");
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.BaudRate = 9600;
            sp.Open();
            while (true)
            {
                sp.WriteLine("HellO");
            }
            sp.Close();
        }
    }
}
