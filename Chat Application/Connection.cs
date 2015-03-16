using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application
{
    public partial class Connection : Form
    {
        Socket listener = null;
        Byte[] buffer = new Byte[1024];

        public static void ConnectCallBack(IAsyncResult ia)
        {
            try
            {
                Socket client = (Socket)ia.AsyncState;
                client.EndConnect(ia);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public Connection()
        {
            try
            {
                InitializeComponent();
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Loopback, 80);
                listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                listener.BeginConnect(localEndPoint, new AsyncCallback(ConnectCallBack), listener);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void enterServer_Click(object sender, EventArgs e)
        {
            String login = textBoxUsername.Text + "::";
            String pwd = textPassword.Text;
            Byte[] enc = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(Encoding.ASCII.GetBytes(pwd));

            login += Encoding.ASCII.GetString(enc);
            buffer = Encoding.ASCII.GetBytes(login);
            listener.Send(buffer);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
