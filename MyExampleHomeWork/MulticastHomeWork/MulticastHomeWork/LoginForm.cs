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

namespace MulticastHomeWork
{
    public partial class LoginForm : Form
    {
        public string userName;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            soc.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 2);
            IPAddress dest = IPAddress.Parse("224.5.5.5");
            soc.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(dest));
            IPEndPoint ipep = new IPEndPoint(dest, 4567);
            soc.Connect(ipep);
            soc.Send(Encoding.Default.GetBytes("JonedTheRoom|" + txtNickname.Text + "|"+"\r\n"));
            soc.Close();
            userName = txtNickname.Text;
            this.Close();
        }
    }
}
