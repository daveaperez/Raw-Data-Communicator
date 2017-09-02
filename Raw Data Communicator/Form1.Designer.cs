namespace Raw_Data_Communicator
{
    partial class Form1
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
            this.textToSend = new System.Windows.Forms.TextBox();
            this.sendTextButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendCommandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textToSend
            // 
            this.textToSend.Location = new System.Drawing.Point(12, 12);
            this.textToSend.Multiline = true;
            this.textToSend.Name = "textToSend";
            this.textToSend.Size = new System.Drawing.Size(260, 118);
            this.textToSend.TabIndex = 0;
            // 
            // sendTextButton
            // 
            this.sendTextButton.Enabled = false;
            this.sendTextButton.Location = new System.Drawing.Point(124, 136);
            this.sendTextButton.Name = "sendTextButton";
            this.sendTextButton.Size = new System.Drawing.Size(148, 23);
            this.sendTextButton.TabIndex = 1;
            this.sendTextButton.Text = "Send Text";
            this.sendTextButton.UseVisualStyleBackColor = true;
            this.sendTextButton.Click += new System.EventHandler(this.sendTextButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 136);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendCommandButton
            // 
            this.sendCommandButton.Location = new System.Drawing.Point(124, 166);
            this.sendCommandButton.Name = "sendCommandButton";
            this.sendCommandButton.Size = new System.Drawing.Size(148, 23);
            this.sendCommandButton.TabIndex = 3;
            this.sendCommandButton.Text = "Send Command";
            this.sendCommandButton.UseVisualStyleBackColor = true;
            this.sendCommandButton.Click += new System.EventHandler(this.sendCommandButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sendCommandButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.sendTextButton);
            this.Controls.Add(this.textToSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textToSend;
        private System.Windows.Forms.Button sendTextButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button sendCommandButton;
    }
}

