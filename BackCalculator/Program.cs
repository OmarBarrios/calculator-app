using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels.Tcp;

namespace BackCalculator
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TicketServer();
        }
        static void TicketServer()
        {
            
            TcpChannel tcpChannel = new TcpChannel(9998);
            ChannelServices.RegisterChannel(tcpChannel);
            
            Type commonInterfaceType = Type.GetType("BackCalculator.Calculator");

            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType,
            "Calculator", WellKnownObjectMode.Singleton);
            
            Console.Write("Backend started...");
            Console.Read();
            
        }

    }

}
