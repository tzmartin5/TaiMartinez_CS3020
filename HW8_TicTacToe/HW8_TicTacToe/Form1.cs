using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace HW8_TicTacToe
{
    public partial class Form1 : Form
    {

        TcpClient connection;

        bool turn = true; //true = x turn, false = y turn
        int turnCount = 0;


        public Form1()
        {
            InitializeComponent();
            Label_LocalIP.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
        }

        private void AddToMessageBox(string s)
        {
            //Must invoke as delegate due to cross thread work
            this.Invoke(new MethodInvoker(delegate
            {
                RichTextBox_Message.AppendText(s + "\n");
                RichTextBox_Message.ScrollToCaret();
            }));
        }

        private void SendButton(Button s)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (turn) {
                    s.Text = "X";
                    s.Enabled = false;
                    turn = false;
                }
                else {
                    s.Text = "O";
                    s.Enabled = false;
                    turn = true;
                }

            }));
        }

        private async void Button_OpenConnection_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new TcpClient(TextBox_InputIP.Text, 5555);
                  
            }
            catch
            {
                AddToMessageBox("No listener found, opening listener.");
                TcpListener listener = new TcpListener(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork), 5555);
                listener.Start();
                connection = await listener.AcceptTcpClientAsync();
                await Task.Factory.StartNew(() => ListenForPacket(connection));
                listener.Stop();
                return;
            }
            AddToMessageBox("Listener found, connection successful.");
            await Task.Factory.StartNew(() => ListenForPacket(connection));
        }

        private void Button_SendPing_Click(object sender, EventArgs e)
        {
            SendMessage(connection, DateTime.Now.ToLongTimeString());
        }

        private void ListenForPacket(TcpClient singleConnection)
        {

            Button[] buttons = { A1, B1, C1, A2, B2, C2, A3, B3, C3 };

            NetworkStream stream = singleConnection.GetStream();
            while (true)
            {
                byte[] bytesToRead = new byte[singleConnection.ReceiveBufferSize];
                int bytesRead = stream.Read(bytesToRead, 0, singleConnection.ReceiveBufferSize);
                string result = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                if (result != "")
                {
                    AddToMessageBox(result);


                    switch (result)
                    {
                        case "A1":
                            SendButton(A1);
                            break;
                        case "B1":
                            SendButton(B1);
                            break;
                        case "C1":
                            SendButton(C1);
                            break;
                        case "A2":
                            SendButton(A2);
                            break;
                        case "B2":
                            SendButton(B2);
                            break;
                        case "C2":
                            SendButton(C2);
                            break;
                        case "A3":
                            SendButton(A3);
                            break;
                        case "B3":
                            SendButton(B3);
                            break;
                        case "C3":
                            SendButton(C3);
                            break;
                    }


                }

            }
        }
      

        private void SendMessage(TcpClient singleConnection, string s)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(s);
            singleConnection.GetStream().Write(bytesToSend, 0, bytesToSend.Length);
        }


        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            SendButton(b);
            SendMessage(connection, b.Name);


            AddToMessageBox("Opponents Turn");
          
            turnCount++;

            checkForWinner();

        }


        private void checkForWinner()
        {
            bool winner = false;

            //horizontal checks 
            if((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled)) 
            {
                winner = true;
            }
           else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                winner = true;
            }

            //vertical checks 
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
            }


            //diagonal checks 
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                winner = true;
            }
            

            if (winner)
            {
                disableButtons();

                String playerWin = "";

                if (turn)
                    playerWin = "Player Two";
                else
                    playerWin = "Player One";

                MessageBox.Show(playerWin + " wins!");
            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("It's a draw :(");
                }
            }

        }


        //disables all buttons when there is a winner
        private void disableButtons()
        {
            try
          {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
           }catch { }
        }














    }
}
