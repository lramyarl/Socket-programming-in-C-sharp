using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Side
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void Client_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(tbxServerIp.Text);

            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            tbxMessages.Text += e.IpPort + " : " + Encoding.UTF8.GetString(e.Data)+ Environment.NewLine;
        }

        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            tbxMessages.Text += "You Exit The Chat... " + Environment.NewLine;

        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            tbxMessages.Text += "You Are Connected... " + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                client.Connect();
                client.Send("##" + tbxUsername.Text);
                tbxSend.Enabled = true;
                btnSend.Enabled = true;
                tbxServerIp.Enabled = false;
                button1.Enabled = false;
                tbxUsername.Enabled = false;
                tbx_Contact.Enabled = true;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            { 
                if (!string.IsNullOrEmpty(tbxSend.Text)&& (!string.IsNullOrEmpty(tbx_Contact.Text)))
                {   

                   
                   client.Send("++" + tbx_Contact.Text + "#" + tbxSend.Text);
                   tbxMessages.Text += tbxUsername.Text + " : " + tbxSend.Text+ Environment.NewLine;
                   tbxSend.Text = "Write your message Here... ";



                }
                else if (!string.IsNullOrEmpty(tbxSend.Text) && string.IsNullOrEmpty(tbx_Contact.Text))
                {
                    client.Send(tbxSend.Text);
                    tbxMessages.Text += tbxUsername.Text + " : " + tbxSend.Text + Environment.NewLine;
                    tbxSend.Text = "Write your message Here... ";
                }

            }
        }
    }
}
