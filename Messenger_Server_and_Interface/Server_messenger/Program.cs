using Server_messenger;
using System;
using System.Threading;

namespace Server_messenger
{
    class Program
    {
        static ServerObject server; 
        static Thread listenThread; 
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(args[1] +"  "+ args[0]);
                server = new ServerObject(args[1], args[0]);
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start(); //старт потока
            }
            catch (Exception ex)
            {
                server.Disconnect();
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}