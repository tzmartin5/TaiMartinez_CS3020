using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku
{
    public class BoardGenerator
    {

        int[,] mat;
        int N;
        int SRN;
        int K;

        public BoardGenerator(int N, int K)
        {
            this.N = N;
            this.K = K;

            Double SRNd = Math.Sqrt(N);
            SRN = Convert.ToInt32(SRNd);

            mat = new int[N, N];
        }

        public void fillValues()
        {
            fillDiagonal();

            fillRemaining(0, SRN);

            removeKDigits();
        }

        public void fillDiagonal()
        {
            for (int i = 0; i < N; i = i + SRN)
            {
                fillBox(i, i);
            }
        }


        bool unUsedInBox(int rowStart, int colStart, int num)
        {
            for (int i = 0; i < SRN; i++)
            {
                for (int j = 0; j < SRN; j++)
                {
                    if (mat[rowStart + i, colStart + j] == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void fillBox(int row, int col)
        {
            int num;
            for (int i = 0; i < SRN; i++)
            {
                for (int j = 0; j < SRN; j++)
                {
                    do
                    {
                        num = randomGenerator(N);
                    }
                    while (!unUsedInBox(row, col, num));

                    mat[row + i, col + j] = num;
                }
            }
        }




        int randomGenerator(int num)
        {
            Random random = new Random();
            return (random.Next(num) + 1);

        }


        // Check if safe to put in cell 
        bool CheckIfSafe(int i, int j, int num)
        {
            return (unUsedInRow(i, num) &&
                    unUsedInCol(j, num) &&
                    unUsedInBox(i - i % SRN, j - j % SRN, num));
        }

        // check in the row for existence 
        bool unUsedInRow(int i, int num)
        {
            for (int j = 0; j < N; j++)
                if (mat[i, j] == num)
                    return false;
            return true;
        }

        // check in the row for existence 
        bool unUsedInCol(int j, int num)
        {
            for (int i = 0; i < N; i++)
                if (mat[i, j] == num)
                    return false;
            return true;
        }

        // A recursive function to fill remaining  
        // matrix 
        bool fillRemaining(int i, int j)
        {
            //  System.out.println(i+" "+j); 
            if (j >= N && i < N - 1)
            {
                i = i + 1;
                j = 0;
            }
            if (i >= N && j >= N)
                return true;

            if (i < SRN)
            {
                if (j < SRN)
                    j = SRN;
            }
            else if (i < N - SRN)
            {
                if (j == (int)(i / SRN) * SRN)
                    j = j + SRN;
            }
            else
            {
                if (j == N - SRN)
                {
                    i = i + 1;
                    j = 0;
                    if (i >= N)
                        return true;
                }
            }

            for (int num = 1; num <= N; num++)
            {
                if (CheckIfSafe(i, j, num))
                {
                    mat[i, j] = num;
                    if (fillRemaining(i, j + 1))
                        return true;

                    mat[i, j] = 0;
                }
            }
            return false;
        }

        // Remove the K no. of digits to 
        public void removeKDigits()
        {
            int count = K;
            while (count != 0)
            {
                int cellId = randomGenerator(N * N);

                // extract coordinates i  and j 
                int i = (cellId / N);
                int j = cellId % 9;
                if (j != 0)
                    j = j - 1;

                if (mat[i, j] != 0)
                {
                    count--;
                    mat[i, j] = 0;
                }
            }
        }

        // write board to file 
        public void printSudoku()
        {
            using (StreamWriter file =
            new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\" + "BoardGen.txt", true))
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if(mat[i,j] == 0)
                        {
                            file.Write(".");
                        }
                        else
                        {
                            file.Write(mat[i, j]);

                        }

                    }
                }
            }
        }
    }
}

