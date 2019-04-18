using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TextBox[,] txtSquare = new TextBox[10, 10];
        private SudokuGrid grid;
        private int tempR = 0;
        private int tempC = 0;

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    txtSquare[i, j] = new TextBox();
                    txtSquare[i, j].Name = i + "" + j;
                    txtSquare[i, j].Text = "";
                    txtSquare[i, j].Multiline = true;
                    txtSquare[i, j].Size = new Size(50, 50);
                    txtSquare[i, j].Location = new Point(10 + ((j - 1) * 55), 30 + ((i - 1) * 55));
                    txtSquare[i, j].ReadOnly = true;
                    txtSquare[i, j].TextAlign = HorizontalAlignment.Center;
                    txtSquare[i, j].TabStop = false;
                    txtSquare[i, j].Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
                    txtSquare[i, j].Cursor = Cursors.Default;
                    txtSquare[i, j].ContextMenuStrip = mnuInput;
                    if ((i + j) % 2 == 0)
                    {
                        txtSquare[i, j].BackColor = Color.LightBlue;
                    }
                    this.Controls.Add(txtSquare[i, j]);
                    txtSquare[i, j].MouseDown += new MouseEventHandler(HandleInput);
                }
            }
            grid = new SudokuGrid();
            UpdateDisplay();
        }


        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(Pens.Black, 172, 30, 172, 520);
            g.DrawLine(Pens.Black, 337, 30, 337, 520);
            g.DrawLine(Pens.Black, 10, 192, 500, 192);
            g.DrawLine(Pens.Black, 10, 357, 500, 357);
        }


        private void UpdateDisplay()
        {
            Font smallFont = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
            Font largeFont = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (grid[i, j].Value == 0)
                    {
                        txtSquare[i, j].Font = smallFont;
                        txtSquare[i, j].Text = grid[i, j].DisplayCandidates();
                    }
                    else
                    {
                        txtSquare[i, j].Font = largeFont;
                        txtSquare[i, j].Text = System.Convert.ToString(grid[i, j].Value);
                    }
                }
            }
        }


        private void HandleInput(object sender, MouseEventArgs e)
        {
            TextBox myTemp = (TextBox)sender;
            string name = myTemp.Name;
            tempR = System.Convert.ToInt32(name.Substring(0, 1));
            tempC = System.Convert.ToInt32(name.Substring(1));
        }

        private void mnuInput_Opening(object sender, CancelEventArgs e)
        {
            mnuInput.Items.Clear();
            if (grid[tempR, tempC].Value == 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (grid[tempR, tempC][i] == 0)
                    {
                        mnuInput.Items.Add("Make " + i);
                    }
                }
            }
            else
            {
                mnuInput.Items.Add("Remove Number");
            }
        }

        private void mnuInput_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (grid[tempR, tempC].Value == 0)
            {
                int valToEnter = System.Convert.ToInt32(e.ClickedItem.Text.Substring(5));
                mnuInput.Close();
                grid.EnterItem(tempR, tempC, valToEnter);
            }
            else
            {
                //to add - remove the number
            }
            UpdateDisplay();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Open A Sudoku Puzzle";
            od.Filter = "Sudoku Puzzle|*.txt";
            if (od.ShowDialog() == DialogResult.OK)
            {
                grid.ReadValues(File.ReadAllText(od.FileName));
                UpdateDisplay();
            }
        }
    } //end form class 


    class GridSquare
    {
        private int GridRow;
        private int GridCol;
        private int SquareValue = 0;
        private int[] SquareCandidates = new int[10] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int GridMiniSquare;
        public GridSquare(int r, int c)
        {
            GridRow = r;
            GridCol = c;
            GridMiniSquare = (int)((c - 1) / 3) + (3 * (int)((r - 1) / 3));

        }
        public int MiniSquare
        {
            get { return GridMiniSquare; }

        }
        public int Value
        {
            get { return SquareValue; }
            set { SquareValue = value; }
        }
        public int Row
        {
            get { return GridRow; }
            set { GridRow = value; }
        }
        public int Col
        {
            get { return GridCol; }
            set { GridCol = value; }
        }
        public int this[int i]
        {
            get { return SquareCandidates[i]; }
            set { SquareCandidates[i] = value; }
        }
        public int NumCandidates()
        {
            int sumCands = 0;
            for (int i = 1; i <= 9; i++)
            {
                sumCands += SquareCandidates[i];
            }
            sumCands = 9 - sumCands;
            return sumCands;
        }
        public string DisplayCandidates()
        {
            string cands = "";
            for (int i = 1; i <= 9; i++)
            {
                if (SquareCandidates[i] == 0)
                {
                    cands += i + " ";
                }
                else
                {
                    cands += " ";
                }
            }
            return cands;
        }

    }


    class SudokuGrid
    {
        private GridSquare[,] GridCell = new GridSquare[10, 10];
        private int[,] GridRefs = { { 1, 1 }, { 1, 4 }, { 1, 7 }, { 4, 1 }, { 4, 4 }, { 4, 7 }, { 7, 1 }, { 7, 4 }, { 7, 7 } };

        public SudokuGrid()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    GridCell[i, j] = new GridSquare(i, j);
                }
            }
        }
        public GridSquare this[int i, int j]
        {
            get { return GridCell[i, j]; }
        }
        public void EnterItem(int row, int col, int cellvalue)
        {
            GridCell[row, col].Value = cellvalue;
            //eliminate from columns and rows
            for (int i = 1; i <= 9; i++)
            {
                if (i != row)
                {
                    GridCell[row, i][cellvalue] = 1;
                }
                if (i != col)
                {
                    GridCell[i, col][cellvalue] = 1;
                }
            }
            //eliminate from minisquares
            for (int i = GridRefs[GridCell[row, col].MiniSquare, 0]; i <= GridRefs[GridCell[row, col].MiniSquare, 0] + 2; i++)
            {
                for (int j = GridRefs[GridCell[row, col].MiniSquare, 1]; j <= GridRefs[GridCell[row, col].MiniSquare, 1] + 2; j++)
                {
                    GridCell[i, j][cellvalue] = 1;
                }
            }
        }


        public void ClearGrid()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    GridCell[i, j] = new GridSquare(i, j);
                }
            }
        }

        public void ReadValues(string ValueString)
        {
            //To do: Add code to check format of the string

            ClearGrid();
            int numCount = 0;
            int newValue = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    newValue = System.Convert.ToInt32(ValueString.Substring(numCount, 1));
                    if (newValue != 0)
                    {
                        EnterItem(i, j, newValue);
                    }
                    numCount++;
                }
            }
        }






    }






} //end of namespace 
