using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachineExtraCredit
{
    public partial class Form1 : Form
    {
        Rotor[] rotors = new Rotor[4];
        Reflector reflector;
        Machine machine;

        public Form1()
        {
            InitializeComponent();

            //intialize routers and reflector 
            rotors[0] = new Rotor(new List<int>() { 1, 2, 4, 7, 1, 9, 2, 0, 1, 3 }, 0);
            rotors[1] = new Rotor(new List<int>() { 0, 2, 3, 9, 2, 4, 5, 7, 0, 8 }, 0);
            rotors[2] = new Rotor(new List<int>() { 5, 8, 9, 4, 9, 3, 4, 5, 6, 7 }, 0);
            rotors[3] = new Rotor(new List<int>() { 1, 5, 3, 9, 5, 5, 1, 7, 5, 9 }, 0);
            reflector = new Reflector(new List<int>() { 3, 6, 8, 0, 5, 4, 1, 9, 2, 7 });
        }

        private void TextBox_Input_TextChanged(object sender, EventArgs e)
        {
            Rotor first = new Rotor(First_1.Checked ? rotors[0] : First_2.Checked ? rotors[1] : First_3.Checked ? rotors[2] : rotors[3]);
            Rotor middle = new Rotor(Middle_1.Checked ? rotors[0] : Middle_2.Checked ? rotors[1] : Middle_3.Checked ? rotors[2] : rotors[3]);
            Rotor last = new Rotor(Last_1.Checked ? rotors[0] : Last_2.Checked ? rotors[1] : Last_3.Checked ? rotors[2] : rotors[3]);



            Reflector reflector = new Reflector(new List<int>() { 3, 6, 8, 0, 5, 4, 1, 9, 2, 7 });


            machine = new Machine(first, int.Parse(Left_Position.Text), middle, int.Parse(Middle_Position.Text), last, int.Parse(Right_Position.Text), reflector);

            //output the answer 
            string input = TextBox_Input.Text;
            string output = "";
            foreach (char c in input)
            {
                output += machine.InputValue(int.Parse(c.ToString()));
            }
            TextBox_Output.Text = output;
        }


    }
}
