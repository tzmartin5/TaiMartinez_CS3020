namespace HW8_TicTacToe
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
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.TextBox_Turn = new System.Windows.Forms.TextBox();
            this.Label_Turn = new System.Windows.Forms.Label();
            this.Button_Exit = new System.Windows.Forms.Button();
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
            this.TextBox_InputIP.Location = new System.Drawing.Point(32, 723);
            this.TextBox_InputIP.Name = "TextBox_InputIP";
            this.TextBox_InputIP.Size = new System.Drawing.Size(297, 38);
            this.TextBox_InputIP.TabIndex = 4;
            // 
            // Label_InputIP
            // 
            this.Label_InputIP.AutoSize = true;
            this.Label_InputIP.Location = new System.Drawing.Point(32, 675);
            this.Label_InputIP.Name = "Label_InputIP";
            this.Label_InputIP.Size = new System.Drawing.Size(266, 32);
            this.Label_InputIP.TabIndex = 5;
            this.Label_InputIP.Text = "Input Opponents IP:";
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(545, 31);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(221, 212);
            this.A1.TabIndex = 6;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.Button_Click);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(800, 31);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(221, 212);
            this.A2.TabIndex = 7;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.Button_Click);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(1056, 31);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(221, 212);
            this.A3.TabIndex = 8;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.Button_Click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(545, 268);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(221, 212);
            this.B1.TabIndex = 9;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.Button_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(800, 268);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(221, 212);
            this.B2.TabIndex = 10;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Button_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(1056, 268);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(221, 212);
            this.B3.TabIndex = 11;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Button_Click);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(545, 508);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(221, 212);
            this.C1.TabIndex = 12;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.Button_Click);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(800, 508);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(221, 212);
            this.C2.TabIndex = 13;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.Button_Click);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(1056, 508);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(221, 212);
            this.C3.TabIndex = 14;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.Button_Click);
            // 
            // TextBox_Turn
            // 
            this.TextBox_Turn.Location = new System.Drawing.Point(1332, 119);
            this.TextBox_Turn.Multiline = true;
            this.TextBox_Turn.Name = "TextBox_Turn";
            this.TextBox_Turn.Size = new System.Drawing.Size(184, 109);
            this.TextBox_Turn.TabIndex = 15;
            // 
            // Label_Turn
            // 
            this.Label_Turn.AutoSize = true;
            this.Label_Turn.Location = new System.Drawing.Point(1326, 84);
            this.Label_Turn.Name = "Label_Turn";
            this.Label_Turn.Size = new System.Drawing.Size(81, 32);
            this.Label_Turn.TabIndex = 16;
            this.Label_Turn.Text = "Turn:";
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(309, 523);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(204, 60);
            this.Button_Exit.TabIndex = 17;
            this.Button_Exit.Text = "Exit Program";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1559, 793);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Label_Turn);
            this.Controls.Add(this.TextBox_Turn);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
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
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.TextBox TextBox_Turn;
        private System.Windows.Forms.Label Label_Turn;
        private System.Windows.Forms.Button Button_Exit;
    }
}

