using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TcpTestClient
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();

            Disposed += OnDisposed;
        }

        private void ConnectButtonClick(object sender, EventArgs e)
        {
            try
            {
                ClientView view = new ClientView(hostTextBox.Text, (ushort)portField.Value);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("The port value you entered was either too low or too high.");
            }
        }

        private void ListenButtonClick(object sender, EventArgs e)
        {
            try
            {
                ServerView view = new ServerView(hostTextBox.Text, (ushort)portField.Value);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("The port value you entered was either too low or too high.");
            }
        }

        private void OnDisposed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}