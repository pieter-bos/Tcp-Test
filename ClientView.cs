using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace TcpTestClient
{
    public partial class ClientView : Form
    {
        public ClientView(string hostname, ushort port)
        {
            InitializeComponent();

            Show();

            TcpClientControl view = new TcpClientControl();
            Controls.Add(view);

            try
            {
                TcpClient client = new TcpClient(hostname, port);
                view.SetTcpClient(client);
                view.Disposed += OnDisposed;
            }
            catch (SocketException)
            {
                MessageBox.Show("Couldn't connect.");
                Dispose();
            }
        }

        private void OnDisposed(object sender, EventArgs args)
        {
            Dispose();
        }
    }
}