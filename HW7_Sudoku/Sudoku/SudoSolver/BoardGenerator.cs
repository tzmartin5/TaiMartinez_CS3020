using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SudoSolver
{
    public class BoardGenerator
    {

        public static void makeBoard(int[,] board) {

            int counter = 0;


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = numGen();
                    while (checkRow(board, i, j))
                    {
                        board[i, j] = numGen();
                        counter++;

                        if (counter == 100)
                        {
                            i = 0;
                            j = 0;
                            for (int k = 0; k < 9; k++)
                            {
                                for (int l = 0; l < 9; l++)
                                {
                                    board[k, l] = 0;
                                }
                            }
                        }
                    }
                    counter = 0;
                    
   

                }
            }

            //open file and output to file 

            string path = @"C: \Users\tayma\Desktop\sudo - solver - master\Saved Puzzles\BoardGen.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                    sw.Write("This is written to the file");

                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            sw.Write(board[i, j]);

                        }
                    }
                }
            }

           


        }

       static int numGen()
        {
            Random random = new Random();

            int value = (random.Next(9) + 1);
            return value;
        }

       static bool checkRow(int [, ] board , int i, int j)
        {
            for(int k = 0; k < 9; k++)
            {
                if(j == k)
                {
                    continue;
                } else if(board[i,j] == board[i, k])
                {
                    return true;
                }
            }

            for (int k = 0; k < 9; k++)
            {
                if (i == k)
                {
                    continue;
                }
                else if (board[i, j] == board[k, i])
                {
                    return true;
                }
            }

            return false;

        }




    }
}
