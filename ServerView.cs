using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace TcpTestClient
{
    public partial class ServerView : Form
    {
        int n = 0;

        TcpListener server;
        Thread listeningThread;

        public ServerView(string hostname, ushort port)
        {
            InitializeComponent();

            Show();

            try
            {
                server = new TcpListener(IPAddress.Parse(hostname), port);
                server.Start();

                listeningThread = new Thread(Listen);
                listeningThread.Start();

                Disposed += OnDispose;
            }
            catch(FormatException)
            {
                MessageBox.Show("You entered a hostname that could not be parsed as an ip-address");
                Dispose();
            }
            catch(SocketException)
            {
                MessageBox.Show("Something went wrong while starting the server. Have you entered your ip-address and a port number that is not yet listened on?");
                Dispose();
            }
        }

        private void AddStatus(string status)
        {
            Invoke((Action)(() => statusLabel.Text += status + Environment.NewLine));
        }

        private void Listen()
        {
            AddStatus("Listener started.");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                AddStatus("New Client: " + n.ToString());
                AddStatus("Processing...");

                TabPage tab = new TabPage("Client " + n.ToString());
                n++;

                TcpClientControl control = new TcpClientControl();
                tab.Controls.Add(control);
                control.Disposed += OnTcpClientControlDispose;

                Invoke((Action)(() => mainTabControl.TabPages.Add(tab)));

                control.SetTcpClient(client);

                AddStatus("Done.");
            }
        }

        private void OnTcpClientControlDispose(object sender, EventArgs args)
        {
            foreach(TabPage page in mainTabControl.TabPages)
            {
                if (page.Controls.Count == 0)
                {
                    page.Dispose();
                }
            }
        }

        private void OnDispose(object sender, EventArgs args)
        {
            foreach (TabPage page in mainTabControl.TabPages)
            {
                if(page.Controls.Count > 0 && page.Controls[0] as TcpClientControl != null)
                    (page.Controls[0] as TcpClientControl).Dispose();
            }
        }
    }
}