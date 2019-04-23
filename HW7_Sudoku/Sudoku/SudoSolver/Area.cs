using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    
    public class Area
    {
        public Square[] squares;
        public Board board;


        public List<Square> blankSquares;
        public List<int> remainingNumbers;

        
        public int M;
        public int Number;

        public Area(int m, Board newBoard, int number)
        {
            M = m;
            board = newBoard;
            Number = number;
            squares = new Square[M];
        }

        public void initAvailabilityLists()
        {
            // All squares start blank and all numbers start available
            blankSquares = squares.ToList();
            remainingNumbers = Enumerable.Range(1, M).ToList();
        }

        public void NotifySquareSet(Square square, int num)
        {
            remainingNumbers.Remove(num);
            blankSquares.Remove(square);
            board.setChangeMade();
        }

       
        public bool IsComplete()
        {
            return remainingNumbers.Count == 0;
        }

        //block certain numbers in the array
        public void blockInAllSquares(int num, params Square[] excluded)
        {
            foreach (var square in blankSquares.Except(excluded))
            {
                if (square.IsAvailable(num))
                {
                    square.Block(num);
                    board.setChangeMade();
                }
            }
        }

        //makes sure all squares are filled when solved 
        public void checkEachEmptySquare()
        { 
            var openingsByNumber = new Dictionary<int, List<Square>>();

            foreach (var num in remainingNumbers)
            {
                var openings = new List<Square>();

                foreach (var square in blankSquares)
                {
                    if (square.IsAvailable(num))
                    {
                        openings.Add(square);
                    }
                }

                //recursively check the puzzle
                if (openings.Count == 1)
                {
                    openings[0].Number = num;
                    checkEachEmptySquare(); 
                    return;
                }
                else
                {
                    openingsByNumber[num] = openings;

                    if (openings.Count == 2)
                    {
                        var a = openings[0];
                        var b = openings[1];

                       //check where in the row, column, and region the squares have been blocked
                        if (!(this is Row) && a.Row == b.Row)
                        {
                            a.Row.blockInAllSquares(num, a, b);
                        }
                        else if (!(this is Col) && a.Col == b.Col)
                        {
                            a.Col.blockInAllSquares(num, a, b);
                        }
                        else if (!(this is Region) && a.Region == b.Region)
                        {
                            a.Region.blockInAllSquares(num, a, b);
                        }
                    }
                    else if (openings.Count == 3)
                    {
                        var a = openings[0];
                        var b = openings[1];
                        var c = openings[2];

                        
                        if (!(this is Row) && a.Row == b.Row && b.Row == c.Row)
                        {
                            a.Row.blockInAllSquares(num, a, b, c);
                        }
                        else if (!(this is Col) && a.Col == b.Col && b.Col == c.Col)
                        {
                            a.Col.blockInAllSquares(num, a, b, c);
                        }
                        else if (!(this is Region) && a.Region == b.Region && b.Region == c.Region)
                        {
                            a.Region.blockInAllSquares(num, a, b, c);
                        }
                    }
                }
            }

        }

        
        public void checkGroup(Dictionary<int,List<Square>> openingsByNumber)
        {
            var numberList = openingsByNumber.Keys.ToList();

            for (var i = 2; i <= numberList.Count; i++)
            {
                foreach (var combination in Combinations<int>.Get(numberList, i))
                {
                    var cmbList = combination.ToList();

                    var squareUnion = (from c in combination
                                       from square in openingsByNumber[c]
                                       select square).Distinct().ToList();

                    if (squareUnion.Count == i)
                    {
                        foreach (var num in numberList)
                        {
                            if (!cmbList.Contains(num))
                            {
                                foreach(var square in squareUnion)
                                {
                                    if (square.IsAvailable(num))
                                    {
                                        square.Block(num);
                                        board.setChangeMade();
                                    }
                                }
                            }
                        }

                        return;
                    }
                }
            }
        }
    }

    //sets rows
    class Row : Area
    {
        public Row(int m, Board board, int row) : base(m, board, row)
        {
            for (var col = 0; col < m; col++)
            {
                squares[col] = board[row, col];
                squares[col].Row = this;
            }

            initAvailabilityLists();
        }
    }

    //sets columns
    class Col : Area
    {
        public Col(int m, Board board, int col) : base(m, board, col)
        {
            for (var row = 0; row < m; row++)
            {
                squares[row] = board[row, col];
                squares[row].Col = this;
            }

            initAvailabilityLists();
        }
    }

    //set the 3x3 block
    class Region : Area
    {
        public Region(int n, int m, Board board, int region) : base(m, board, region)
        {
            int counter = 0;
            for (var row = (region / n) * n; row < ((region / n) + 1) * n; row++)
            {
                for (var col = (region % n) * n; col < ((region % n) + 1) * n; col++)
                {
                    squares[counter] =  board[row, col];
                    squares[counter].Region = this;
                    counter++;
                }
            }

            initAvailabilityLists();
        }
    }
}
