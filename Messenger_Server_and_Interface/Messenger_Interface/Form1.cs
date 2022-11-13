using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


namespace Messenger_Interface
{
    public partial class Form1 : Form
    {
        private Person person;
        private Thread receiveThread;
        private Thread MainThread;
        private bool Conected;
        private bool AvailableText = false;
        private string Message;

        public Form1()
        {

            InitializeComponent();
            PortTextBox.Text = Setting.port;
            HostTextBox.Text = Setting.host;
            person = new Person(Setting.UserName,MessageTextBox);
            Conected = false;
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            person.Disconnect();
            Application.Exit();
            this.Close();
            Thread.ResetAbort();
            
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {
                MainThread = new Thread(new ThreadStart(Conect));
                MainThread.Start();
                Conected = true;
            }
            else
            {
                try
                {

                    person.Disconnect();
                    Conected = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }

        private void Conect()
        {
            Setting.host = HostTextBox.Text;
            Setting.port = PortTextBox.Text;

            person.client = new TcpClient();
            try
            {
                person.client.Connect(IPAddress.Parse(Setting.host), int.Parse(Setting.port)); //подключение клиента
                person.stream = person.client.GetStream(); // получаем поток

                string message = Setting.UserName;
                byte[] data = Encoding.Unicode.GetBytes(message);
                person.stream.Write(data, 0, data.Length);

                // запускаем новый поток для получения данных
                receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start();
                Conected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ReceiveMessage()
        {
            while (Conected)
            {
                try
                {
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = person.stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (person.stream.DataAvailable);

                    string resaveMessage = builder.ToString();
                    Message = resaveMessage+"\n";
                    AvailableText = true;
                }
                catch
                {
                    MessageBox.Show("Connection lose!");
                    person.Disconnect();
                    break;
                }
            }
        }



        private void roundButton3_Click(object sender, EventArgs e)
        {
            if (this.WindowState != System.Windows.Forms.FormWindowState.Maximized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            SendMessage(MessageTextBox.Text);
        }

        private void SendMessage(string text)
        {
            if (Conected)
            {
                try
                {
                    if (MessageTextBox.Text == String.Empty)
                        return;
                    string message = text;
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    person.stream.Write(data, 0, data.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Зачекайте підключення");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AvailableText) { 

                AllMessage.AppendText($"{DateTime.Now.ToShortTimeString()} : "+Message);
                AllMessage.AppendText(Environment.NewLine);
                AvailableText = false;
            }
        }
    }
}