namespace TcpTestClient
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.portField = new System.Windows.Forms.NumericUpDown();
            this.connectButton = new System.Windows.Forms.Button();
            this.listenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.portField)).BeginInit();
            this.SuspendLayout();
            // 
            // hostTextBox
            // 
            this.hostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hostTextBox.Location = new System.Drawing.Point(14, 11);
            this.hostTextBox.MaximumSize = new System.Drawing.Size(60000, 20);
            this.hostTextBox.MinimumSize = new System.Drawing.Size(213, 20);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(213, 20);
            this.hostTextBox.TabIndex = 0;
            // 
            // portField
            // 
            this.portField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portField.Location = new System.Drawing.Point(233, 12);
            this.portField.Maximum = new decimal(new int[] {
            655,
            0,
            0,
            0});
            this.portField.Name = "portField";
            this.portField.Size = new System.Drawing.Size(65, 20);
            this.portField.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(304, 9);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(56, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButtonClick);
            // 
            // listenButton
            // 
            this.listenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listenButton.Location = new System.Drawing.Point(367, 9);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(51, 23);
            this.listenButton.TabIndex = 3;
            this.listenButton.Text = "Listen";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.ListenButtonClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 43);
            this.Controls.Add(this.listenButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portField);
            this.Controls.Add(this.hostTextBox);
            this.MaximumSize = new System.Drawing.Size(60000, 81);
            this.MinimumSize = new System.Drawing.Size(440, 81);
            this.Name = "MainView";
            this.Text = "Toolbox";
            ((System.ComponentModel.ISupportInitialize)(this.portField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.NumericUpDown portField;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button listenButton;
    }
}

