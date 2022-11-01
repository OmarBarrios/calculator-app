using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;
using BackCalculator;

namespace FrontCalculator
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
            client();
            
            
        }
        static void client()
        {
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel);
            Type requiredType = typeof(ICalculator);

            ICalculator remoteObject = (ICalculator)Activator.GetObject(requiredType, "tcp://localhost:9998/Calculator");
            Application.Run(new Calculadora(remoteObject));
            // Console.WriteLine("REMOTING:  " + remoteObject.Sum(2,3));

        }
    }
}
