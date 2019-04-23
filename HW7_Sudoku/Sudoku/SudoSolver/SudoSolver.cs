using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SudoSolver
{
    public partial class frmMain : Form
    {
        TextBox[,] boardTextBoxes;
        Panel boardPanel;

        public frmMain()
        {
            InitializeComponent();
        }

        private void generateBoard(int n, int m)
        {
            const int TxtBoxWidth = 25;
            const int TxtBoxHeight = 25;
            const int SquarePadding = 5;
            const int StartPosX = 20;
            const int StartPosY = 40;
            const int PanelPadding = 8;
            const int MaxTextLength = 2;

            if (boardTextBoxes != null && boardTextBoxes.GetLength(0) == m)
            {
                foreach (var box in boardTextBoxes)
                {
                    box.Text = "";
                    styleAsDefault(box);
                }
            }
            else
            {
                SuspendLayout();

                // Dispose the existing controls
                if (boardTextBoxes != null)
                {
                    foreach (var box in boardTextBoxes)
                    {
                        box.Dispose();
                    }
                }
                if (boardPanel != null)
                {
                    boardPanel.Dispose();
                }

                boardPanel = new Panel();
                boardPanel.Location = new Point(StartPosX, StartPosY);
                boardPanel.Size = new Size(PanelPadding * 2 + SquarePadding * (n - 1) + m * TxtBoxWidth,
                                            PanelPadding * 2 + SquarePadding * (n - 1) + m * TxtBoxHeight);
                boardPanel.BackColor = Color.PowderBlue;
                Controls.Add(boardPanel);
                boardTextBoxes = new TextBox[m, m];

                for (var row = 0; row < boardTextBoxes.GetLength(0); row++)
                {
                    for (var col = 0; col < boardTextBoxes.GetLength(1); col++)
                    {
                        boardTextBoxes[row, col] = new TextBox();
                        boardTextBoxes[row, col].Multiline = true;
                        boardTextBoxes[row, col].Size = new Size(TxtBoxWidth, TxtBoxHeight);

                        boardTextBoxes[row, col].Location = new Point(
                                                PanelPadding + (TxtBoxWidth * col) + (SquarePadding * (col / n))
                                                , PanelPadding + (TxtBoxHeight * row) + (SquarePadding * (row / n)));
                        boardTextBoxes[row, col].MaxLength = MaxTextLength;
                        boardTextBoxes[row, col].TextAlign = HorizontalAlignment.Center;

                        boardPanel.Controls.Add(boardTextBoxes[row, col]);
                    }
                }

                ResumeLayout();
            }
        }

        private Board makeBoardFromText()
        {
            var m = boardTextBoxes.GetLength(0);
            var newBoard = new Board(Convert.ToInt32(Math.Sqrt(m)));

            for (var row = 0; row < m; row++)
            {
                for (var col = 0; col < m; col++)
                {
                    if (boardTextBoxes[row, col].Text != "")
                        newBoard[row, col].Number = Convert.ToInt32(boardTextBoxes[row, col].Text);
                }
            }

            return newBoard;
        }

        private void setTextFromBoard(Board board, bool isSolution = false)
        {
            if (!isSolution)
                generateBoard(board.N, board.M);

            for (var row = 0; row < board.M; row++)
            {
                for (var col = 0; col < board.M; col++)
                {
                    if (isSolution && string.IsNullOrWhiteSpace(boardTextBoxes[row, col].Text))
                    {
                        boardTextBoxes[row, col].Text = board[row, col].ToString();
                        styleAsSolution(boardTextBoxes[row, col]);
                    }
                    else if (!isSolution)
                    {
                        boardTextBoxes[row, col].Text = board[row, col].ToString();
                        if (boardTextBoxes[row, col].Text != "")
                        {
                            styleAsGiven(boardTextBoxes[row, col]);
                        }
                    }
                }
            }
        }

        private void styleAsSolution(TextBox box)
        {
            box.ReadOnly = false;
            box.ForeColor = Color.Blue;
        }

        private void styleAsDefault(TextBox box)
        {
            box.ReadOnly = false;
            box.ForeColor = Color.Black;
        }

        private void styleAsGiven(TextBox box)
        {
            box.ReadOnly = true;
            box.ForeColor = Color.Black;
        }

        private void solveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (boardTextBoxes != null)
            {
                var newSolve = makeBoardFromText();
                var result = newSolve.solveBoard();

                MessageBox.Show(string.Format("Is Solved: {0}\nGreatest Search Depth: {1}\nSolve Time: {2}ms", result ? "Yes" : "No", newSolve.GreatestDepth, newSolve.SolveTimeMs));

                setTextFromBoard(newSolve, true);
            }
        }

        private void checkProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var board = makeBoardFromText();
            MessageBox.Show(board.IsSolved().ToString());
        }

        private void loadTestBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int N = 9, K = 20;
            BoardGenerator sudoku = new BoardGenerator(N, K);
            sudoku.fillValues();
            sudoku.printSudoku();

            loadBoardFromFile(@"..\..\..\..\Saved Puzzles\BoardGen.txt");
        }


        private void loadPuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           loadBoardFromFile(@"C:\Users\tayma\Documents\TaiMartinez_CS3020\HW7_Sudoku\Saved Puzzles\examples.txt");
        }

        private void loadBoardFromFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                // Read size number - square root of number of rows and columns (3 in a 9x9)
                var n = 3;
                var m = n*n;

                var board = new Board(n);
                
                string rowText = reader.ReadLine();
                char[] charText = rowText.ToCharArray();

                for (var i = 0; i < 9; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 9; j++)
                    {
          
                        if (charText[(i*9) + j] != '.')
                        {

                            int x = IntParse((charText[(i * 9) + j]).ToString());
                            board[i, j].Number = IntParse((charText[(i * 9) + j]).ToString());
                            
                        }
                       
                    }
                }         

                setTextFromBoard(board);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //convert from string to int
        static int IntParse(string Input)
        {
            int Value = 0;
            bool Loop = true;

            Loop = int.TryParse(Input, out Value);

            while (!(Loop))
            {
                Console.WriteLine("Invalid Input, please try again: ");
                Input = Console.ReadLine();
                Loop = int.TryParse(Input, out Value);
            }

            return Value;
        }



    }
}
