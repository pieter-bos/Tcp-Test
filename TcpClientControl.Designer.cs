namespace TcpTestClient
{
    partial class TcpClientControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLineTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(242, 29);
            this.outputTextBox.MaximumSize = new System.Drawing.Size(245, 211);
            this.outputTextBox.MinimumSize = new System.Drawing.Size(245, 211);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(245, 211);
            this.outputTextBox.TabIndex = 5;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(0, 29);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(236, 211);
            this.inputTextBox.TabIndex = 4;
            // 
            // inputLineTextBox
            // 
            this.inputLineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.inputLineTextBox.Location = new System.Drawing.Point(-2, 3);
            this.inputLineTextBox.Name = "inputLineTextBox";
            this.inputLineTextBox.Size = new System.Drawing.Size(427, 20);
            this.inputLineTextBox.TabIndex = 3;
            this.inputLineTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputLineTextBoxKeyPress);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(431, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(56, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // TcpClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputLineTextBox);
            this.Location = new System.Drawing.Point(13, 13);
            this.Name = "TcpClientControl";
            this.Size = new System.Drawing.Size(493, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox inputLineTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}
