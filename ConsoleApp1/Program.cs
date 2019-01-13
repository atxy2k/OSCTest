using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpOSC;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var prueba = new Prueba();
            prueba.ShowDialog();
            /**var message = new SharpOSC.OscMessage("/mxw/set", (23)+1, 42.01f, "hello world");
            var sender = new SharpOSC.UDPSender("192.168.0.8", 7000);
            sender.Send(message);
            Console.Read();**/
        }
    }
}
