﻿namespace HW8_TicTacToe
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
            this.Button_OpenConnection = new System.Windows.Forms.Button();
            this.Button_SendPing = new System.Windows.Forms.Button();
            this.RichTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.Label_LocalIP = new System.Windows.Forms.Label();
            this.TextBox_InputIP = new System.Windows.Forms.TextBox();
            this.Label_InputIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_OpenConnection
            // 
            this.Button_OpenConnection.Location = new System.Drawing.Point(35, 31);
            this.Button_OpenConnection.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Button_OpenConnection.Name = "Button_OpenConnection";
            this.Button_OpenConnection.Size = new System.Drawing.Size(403, 55);
            this.Button_OpenConnection.TabIndex = 0;
            this.Button_OpenConnection.Text = "Open Connection";
            this.Button_OpenConnection.UseVisualStyleBackColor = true;
            this.Button_OpenConnection.Click += new System.EventHandler(this.Button_OpenConnection_Click);
            // 
            // Button_SendPing
            // 
            this.Button_SendPing.Location = new System.Drawing.Point(32, 100);
            this.Button_SendPing.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Button_SendPing.Name = "Button_SendPing";
            this.Button_SendPing.Size = new System.Drawing.Size(403, 55);
            this.Button_SendPing.TabIndex = 1;
            this.Button_SendPing.Text = "Send Ping";
            this.Button_SendPing.UseVisualStyleBackColor = true;
            this.Button_SendPing.Click += new System.EventHandler(this.Button_SendPing_Click);
            // 
            // RichTextBox_Message
            // 
            this.RichTextBox_Message.Enabled = false;
            this.RichTextBox_Message.Location = new System.Drawing.Point(32, 172);
            this.RichTextBox_Message.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RichTextBox_Message.Name = "RichTextBox_Message";
            this.RichTextBox_Message.Size = new System.Drawing.Size(396, 324);
            this.RichTextBox_Message.TabIndex = 2;
            this.RichTextBox_Message.Text = "";
            // 
            // Label_LocalIP
            // 
            this.Label_LocalIP.AutoSize = true;
            this.Label_LocalIP.Location = new System.Drawing.Point(32, 508);
            this.Label_LocalIP.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label_LocalIP.Name = "Label_LocalIP";
            this.Label_LocalIP.Size = new System.Drawing.Size(0, 32);
            this.Label_LocalIP.TabIndex = 3;
            // 
            // TextBox_InputIP
            // 
            this.TextBox_InputIP.Location = new System.Drawing.Point(448, 519);
            this.TextBox_InputIP.Name = "TextBox_InputIP";
            this.TextBox_InputIP.Size = new System.Drawing.Size(297, 38);
            this.TextBox_InputIP.TabIndex = 4;
            // 
            // Label_InputIP
            // 
            this.Label_InputIP.AutoSize = true;
            this.Label_InputIP.Location = new System.Drawing.Point(465, 474);
            this.Label_InputIP.Name = "Label_InputIP";
            this.Label_InputIP.Size = new System.Drawing.Size(119, 32);
            this.Label_InputIP.TabIndex = 5;
            this.Label_InputIP.Text = "Input IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 601);
            this.Controls.Add(this.Label_InputIP);
            this.Controls.Add(this.TextBox_InputIP);
            this.Controls.Add(this.Label_LocalIP);
            this.Controls.Add(this.RichTextBox_Message);
            this.Controls.Add(this.Button_SendPing);
            this.Controls.Add(this.Button_OpenConnection);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_OpenConnection;
        private System.Windows.Forms.Button Button_SendPing;
        private System.Windows.Forms.RichTextBox RichTextBox_Message;
        private System.Windows.Forms.Label Label_LocalIP;
        private System.Windows.Forms.TextBox TextBox_InputIP;
        private System.Windows.Forms.Label Label_InputIP;
    }
}

