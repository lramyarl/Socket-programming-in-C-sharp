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

namespace socketporgraming
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;

        private void lblServerIP_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Datas.Chat_programingEntities2 db;
        private void Server_Load(object sender, EventArgs e)
        {
            db = new Datas.Chat_programingEntities2();
            //tbxIPPort.Text = db.tbl_userList.FirstOrDefault().IpPort;
            server = new SimpleTcpServer("127.0.0.1:9000");
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }
        List<Datas.tbl_AllUsers> userlist = new List<Datas.tbl_AllUsers>();

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            string D = Encoding.UTF8.GetString(e.Data);
            if (D.Substring(0, 2) == "##")
            {
                Datas.tbl_AllUsers newuser = new Datas.tbl_AllUsers();
                newuser.User_ipPport = e.IpPort;
                newuser.User_username = D.Substring(2);
                userlist.Add(newuser);
                tbxMessages.Text += newuser.User_ipPport + " : " + newuser.User_username + "Connected..." +Environment.NewLine;
            }
            else if (D.Substring(0, 2) == "++")
            {
                int count = 1;
                foreach (var item in D.Substring(2))
                {
                    if (item == '#')
                    {
                        break;
                    }
                    count++;
                }

                string qUser_Sender = D.Substring(2, count - 1);
                //Find Ip
                var qUser = userlist.Where(p => p.User_username == qUser_Sender).FirstOrDefault();
                string qUser_Rec = userlist.Where(p => p.User_ipPport == e.IpPort).FirstOrDefault().User_username;
                tbxMessages.Text += qUser_Rec + " Sends Message For " + qUser_Sender + " "  + Environment.NewLine;

                if (qUser != null)
                {
                    server.Send(qUser.User_ipPport, qUser_Rec + " : " + D.Substring(count + 2));
                }

            }
            else
            {
                string qUser_Rec = userlist.Where(p => p.User_ipPport == e.IpPort).FirstOrDefault().User_username;
                foreach (var item in userlist)
                {
                    server.Send(item.User_ipPport, qUser_Rec + " : " + D);
                }
            }

            //    else
            //        tbxMessages.Text += e.IpPort + " : " + Encoding.UTF8.GetString(e.Data) + Environment.NewLine;
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            tbxMessages.Text += e.IpPort + " : Disconnected." + Environment.NewLine;
            //Remove User From list
            string UserName = userlist.Where(p => p.User_ipPport == e.IpPort).FirstOrDefault().User_username;
            lbxUsersList.Items.Remove(UserName);
        }

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            tbxMessages.Text += e.IpPort + " : Connected." + Environment.NewLine;
            lbxUsersList.Items.Add(e.IpPort);

        }

    

    
        private void btnConnectS_Click(object sender, EventArgs e)
        {
            server.Start();
            tbxMessages.Enabled = true;
            tbxMessages.Text += "Server Is Online..." + Environment.NewLine;
            tbxSend.Enabled = true;
            btnSend.Enabled = true;
            lbxUsersList.Enabled = true;
            btnConnectS.Enabled = false;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(tbxSend.Text))
                {
                    try
                    {
                        string ipPort = userlist.Where(p => p.User_username == lbxUsersList.SelectedItem.ToString()).FirstOrDefault().User_ipPport;
                        server.Send(ipPort, "Server : " + tbxSend.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                     
                    }

                    tbxMessages.Text += "Server : " + tbxSend.Text + Environment.NewLine;
                    tbxSend.Text = string.Empty;
                }

            }

        }
    }
}
