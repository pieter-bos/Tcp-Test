using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace TcpTestClient
{
    public partial class TcpClientControl : UserControl
    {
        TcpClient client;
        Thread outputThread;

        private bool initialized = false;

        public TcpClientControl()
        {
            InitializeComponent();

            this.Disposed += OnDisposed;
        }

        public void SetTcpClient(TcpClient client)
        {
            this.client = client;

            initialized = true;

            outputThread = new Thread(HandleOutput);
            outputThread.Start();

            Clear();

            AddInput("Input:");
            AddOutput("Output:");
        }

        private void AddInput(string input)
        {
            Invoke((Action)(() => inputTextBox.Text += input + Environment.NewLine));
        }

        private void ClearInput()
        {
            Invoke((Action)(() => inputTextBox.Text = ""));
        }

        private void AddOutput(string output)
        {
            Invoke((Action)(() => outputTextBox.Text += output + Environment.NewLine));
        }

        private void ClearOutput()
        {
            Invoke((Action)(() => outputTextBox.Text = ""));
        }

        private void Clear()
        {
            ClearOutput();
            ClearInput();
        }

        private void HandleInput(string input)
        {
            if (!initialized) return;

            AddInput(input);
            input += Environment.NewLine;
            try
            {
                client.GetStream().Write(System.Text.Encoding.ASCII.GetBytes(input), 0, input.Length);
            }
            catch (IOException)
            {
                MessageBox.Show("An IO Exception Occured. Either you or the host has disconnected.");
                Dispose();
            }
        }

        private void HandleOutput()
        {
            if (!initialized) return;

            StreamReader output = new StreamReader(client.GetStream());

            try
            {
                while (true)
                {
                    string newOutput = output.ReadLine();

                    if (newOutput == null)
                    {
                        MessageBox.Show("Either the client or the host has disconnected.");
                        Invoke((Action)(() => Dispose()));
                    }
                    else
                    {
                        AddOutput(newOutput);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Either the client or the host has disconnected.");
                Dispose();
            }
            catch(ObjectDisposedException)
            {
                
            }
        }

        private void InputLineTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!initialized) return;

            if (e.KeyChar == (char)13)
            {
                HandleInput(inputLineTextBox.Text);
                inputLineTextBox.Text = "";
                inputLineTextBox.Focus();
            }
        }

        private void OnDisposed(object sender, EventArgs args)
        {
            if(outputThread != null && outputThread.IsAlive) outputThread.Join(0);

            if (client != null && client.Connected) client.Close();
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            if(client != null && client.Connected) client.Close();
            Dispose();
        }
    }
}