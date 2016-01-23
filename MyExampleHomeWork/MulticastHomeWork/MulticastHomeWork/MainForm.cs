using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MulticastHomeWork
{
    public partial class MainForm : Form
    {
        string currUserName = "";
        delegate void AppendText(string text);
        void Listner()
        {
            while (true)
            {
                Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 4567);
                soc.Bind(ipep);
                IPAddress ip = IPAddress.Parse("224.5.5.5");
                soc.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip, IPAddress.Any));
                byte[] buff = new byte[1024];
                soc.Receive(buff);
                this.Invoke(new AppendText(AppendTextProc), Encoding.Default.GetString(buff));
                soc.Close();
            }
        }
        Thread listen;
        //public readonly LoginForm formLogin = new LoginForm();
        public MainForm()
        {
            InitializeComponent();
            listen = new Thread(new ThreadStart(Listner));
            listen.IsBackground = true;
            listen.Start();
        }
        //відправка даних
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage(txtInput.Text, "Message");
        }
        //отримання даних
        void AppendTextProc(string text)
        {
            var cmd = text.Split('|');
            string userNameSend;
            switch (cmd[0])
            {
                case "JonedTheRoom":
                    userNameSend = cmd[1];
                    userList.Items.Clear();
                    userList.Items.Add(userNameSend);
                    txtReceive.Text += "<<" + userNameSend + " joined the room >>\r\n";
                    SendMessage(txtReceive.Text, "UpdateListUser");
                    break;
                case "UpdateListUser":
                    userList.Items.Add(cmd[1]);
                    break;
                case "Message":
                    userNameSend = cmd[1];
                    txtReceive.Text += "" + userNameSend + ">>"+cmd[2]+"\r\n";
                    break;
            }
            txtInput.Text = string.Empty;
        }
        void SendMessage(string text, string type)
        {
            string message = type + "|" + currUserName + "|"+text+"|";
            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            soc.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 2);
            IPAddress dest = IPAddress.Parse("224.5.5.5");
            soc.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(dest));
            IPEndPoint ipep = new IPEndPoint(dest, 4567);
            soc.Connect(ipep);
            soc.Send(Encoding.Default.GetBytes(message));
            soc.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            LoginForm formLogin = new LoginForm();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                currUserName = formLogin.userName;
                Text = "Udp Chat  - (Connected as: " + currUserName + ")";
            }
            else
                this.Close();
        }
    }
}
