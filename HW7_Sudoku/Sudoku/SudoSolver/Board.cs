using System;
using System.Diagnostics;
using System.Linq;

namespace Sudoku
{
    public class Board
    {
        Square[,] board;

        Area[] Rows;
        Area[] Columns;
        Area[] Regions;

        
        public int M;
        public int N;

        bool changeMade;

        public Square this[int index, int y]
        {
            get { return board[index, y]; }
            set { board[index, y] = value; }
        }

        public Board(int n)
        {
            initializeBoard(n);
        }

        public Board(Board original)
        {
            initializeBoard(original.N);
            CopyBoard(original);
        }

        private void initializeBoard(int n)
        {
            N = n;
            M = n * n;

            board = new Square[M, M];
            for (var row = 0; row < M; row++)
            {
                for (var col = 0; col < M; col++)
                {
                    board[row, col] = new Square(M);
                }
            }

            initRowsColsRegions();
        }

        private void initRowsColsRegions()
        {
            
            Rows = new Area[M];

            for (int row = 0; row < Rows.Length; row++)
            {
                Rows[row] = new Row(M, this, row);
                Rows[row].Number = row;
            }

            Columns = new Area[M];
            for (int col = 0; col < Columns.Length; col++)
            {
                Columns[col] = new Col(M, this, col);
                Columns[col].Number = col;
            }

            Regions = new Area[M];
            for (int region = 0; region < Regions.Length; region++)
            {
                Regions[region] = new Region(N, M, this, region);
                Regions[region].Number = region;
            }
        }

        void CopyBoard(Board original)
        {
            for (var row = 0; row < M; row++)
            {
                for (var col = 0; col < M; col++)
                {
                    this[row, col].Copy(original[row, col]);
                }
            }
        }

        public int SolveDepth = 1;
        public int GreatestDepth = 1;
        DateTime startTime;
        DateTime endTime;

        // show time it took to solve puzzle
        public double SolveTimeMs
        {
            get
            {
                Debug.Assert(startTime != null && endTime != null);
                return (endTime - startTime).Milliseconds;
            }
        }

        public bool solveBoard(int solveDepth = 1)
        {
            SolveDepth = solveDepth;

            changeMade = true;
            startTime = DateTime.Now;
            var iterations = 0;

            while (changeMade && IsSolved() == false)
            {
                iterations += 1;

                changeMade = false;

                // Then for each area, check which numbers aren't set. For each unset number, if it only has
                // one place to go, set it there.
                foreach (var row in Rows)
                {
                    row.checkEachEmptySquare();
                }
                foreach (var col in Columns)
                {
                    col.checkEachEmptySquare();
                }
                foreach (var region in Regions)
                {
                    region.checkEachEmptySquare();
                }

                //set numbers to squares
                foreach (var square in board)
                {
                    if (square.HasNumber == false && square.CountAvailable() == 1)
                    {
                        for (var i = 1; i <= M; i++)
                        {
                            if (!square.IsBlocked(i))
                            {
                                square.Number = i;
                                setChangeMade();
                                break;
                            }
                        }
                    }
                }
            }
            
            if (IsSolved() == false)
            {
                var square = SquareWithFewestOptions;

                if (square == null)
                {
                    return false;
                }
                else
                {
                    for (int num = 1; num <= M; num++)
                    {
                        if (square.IsBlocked(num) == false)
                        {
                            var attempt = new Board(this);
                            attempt[square.RowNumber, square.ColNumber].Number = num;

                            if (attempt.solveBoard(solveDepth + 1))
                            {
                                GreatestDepth = attempt.SolveDepth;
                                if (SolveDepth != 1)
                                    SolveDepth = attempt.SolveDepth;
                                CopyBoard(attempt);
                                break;
                            }
                        }
                    }
                }
            }

            endTime = DateTime.Now;
            return IsSolved();
        }

        
        Square SquareWithFewestOptions
        {
            get
            {
                Square candidate = null;

                foreach(var square in board)
                {
                    if (square.HasNumber == false && (candidate == null || square.CountAvailable() < candidate.CountAvailable()))
                        candidate = square;
                }

                return candidate;
            }
        }

        public void setChangeMade()
        {
            changeMade = true;
        }

        public bool IsSolved()
        {
            return allNumbersInAreas(Rows) && allNumbersInAreas(Columns) && allNumbersInAreas(Regions);
        }

        bool allNumbersInAreas(Area[] areas)
        {
            foreach (var area in areas)
            {
                if (!area.IsComplete()) return false;
            }
            return true;
        }
    }
}
