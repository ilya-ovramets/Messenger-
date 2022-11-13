using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using Messenger_Server;

namespace Messenger_Interface
{
    class Person
    {
        private string userName;
        public TcpClient client;
        public NetworkStream stream;
        public string resaveMessage;
        TextBox textbox;

        public Person(string userName, TextBox textBox)
        {
            this.userName = userName;
            this.textbox = textbox;
        }


        public void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
        }
    }
}