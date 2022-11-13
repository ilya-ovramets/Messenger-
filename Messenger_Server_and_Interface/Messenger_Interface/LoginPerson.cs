using Messenger_Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger_Interface
{
    public partial class LoginPerson : Form
    {
        public LoginPerson()
        {
            InitializeComponent();
            Host.Text = "127.0.0.1";
            Port.Text = "8888";
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                MessageBox.Show("Write your Name");
                return;
            }
            this.Hide();
            Setting.UserName = userName.Text;
            Setting.host = Host.Text;
            Setting.port = Port.Text;

            Form1 form_selected = new Form1();
            form_selected.ShowDialog();
        }

        
    }
}
