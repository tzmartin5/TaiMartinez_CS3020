using System;
using System.Collections;

namespace Sudoku
{
    
    //Each text box square
    public class Square
    {
        public bool HasNumber { get; set; }

        //handles the actual number in the textbox square 
        public int Number
        {
            get
            {
                if (!HasNumber)
                    throw new Exception("Attempting to read number from a blank square.");
                return number;
            }
            set
            {
                if (HasNumber)
                    throw new Exception("Square already has a number.");

                // Set the number
                HasNumber = true;
                number = value;

                Row.NotifySquareSet(this, value);
                Col.NotifySquareSet(this, value);
                Region.NotifySquareSet(this, value);

                Row.blockInAllSquares(value);
                Col.blockInAllSquares(value);
                Region.blockInAllSquares(value);

                for (var i = 0; i < M; i++)
                {
                    isAvailable[i] = false;
                }
            }
        }

        public const int UNSET = 0;
        int number = UNSET;

        BitArray isAvailable;
        int M;

       
        public Area Row { get; set; }

        public Area Col { get; set; }

        public Area Region { get; set; }

        public int ColNumber { get { return Col.Number; } }

        public int RowNumber { get { return Row.Number; } }

        public Square(int m)
        {
            M = m;

            // initalizes all numbers as blank
            isAvailable = new BitArray(m);
            isAvailable.SetAll(true);
        }

        public void Copy(Square original)
        {
            if (HasNumber == false)
            {
                if (original.HasNumber)
                {
                    Number = original.Number;
                }
                else
                {
                    isAvailable = (BitArray)original.isAvailable.Clone();
                }
            }
        }

        //sets if number is available 
        public bool IsAvailable(int num)
        {
            return isAvailable[num - 1];
        }

        //checks if number is blocked
        public bool IsBlocked(int num)
        {
            return isAvailable[num - 1] == false;
        }

        //check available numbers
        public int CountAvailable()
        {
            int count = 0;
            for (var i = 0; i < M; i++)
            { 
                if (isAvailable[i]) count++;
            }
            return count;
        }

        //removes the blocked numbers
        public void Block(int num)
        {
            isAvailable[num- 1] = false;
        }

        public override string ToString()
        {
            return HasNumber ? Number.ToString() : "";
        }
    }
}
