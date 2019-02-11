using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_OOPCharacterBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            char playerOne;
            char playerTwo;


            //prompt player 1 for character choice 
            Console.WriteLine("Player 1, what class do you choose? m,w,a: ");
            playerOne = char.Parse(Console.ReadLine());

            //prompt player 2 for character choice 
            Console.WriteLine("Player 2, waht class do you choose? m,w,a: ");
            playerTwo = char.Parse(Console.ReadLine());

            

            Mage mage = new Mage();
            Warrior warrior = new Warrior();
            Archer archer = new Archer();

            printBoard(23, 28);

            if (playerOne == 'm')
            {
                //print player health points 
                Console.Write("Player 1 HP: {0} -", mage.SetHealth);
            }
            else if(playerOne == 'w')
            {
                //print player health points 
                Console.Write("Player 1 HP: {0} -", warrior.SetHealth);

            } else if(playerOne == 'a')
             {
                //print player health points 
                Console.Write("Player 1 HP: {0} -", archer.SetHealth);

            }

            //handle player two input and create new instances of character 
            if (playerTwo == 'm')
            {
                //print player health points 
                Console.Write("Player 2 HP: {0} ", mage.SetHealth);
            }
            else if (playerTwo == 'w')
            {
                //print player health points 
                Console.Write("Player 2 HP: {0} ", warrior.SetHealth);
            }
            else if (playerTwo == 'a')
            {
                //print player health points 
                Console.Write("Player 2 HP: {0} ", archer.SetHealth);
            }

            while(mage.SetHealth != 0 && warrior.SetHealth != 0 && archer.SetHealth != 0)
            {
                



                //give low priority to player ask what they want to do
                //move and attack 
                //special 

                //if move and attack, how many units to move 
                //you moved, would you like to attack y/n
                //if not next player move 

                //if yes, then 
                //print opted to attack, attack or too far away 


                //if special 
                //apply special damage 



            }














        }  
        
        public static void printBoard(int pOnePosition, int pTwoPosition)
        {

            char[] board = new char[50];

            //initalize board with dashes
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = '-';
            }

            //start players in correct positions and print original board 
            board[pOnePosition] = '1';
            board[pTwoPosition] = '2';

            string updatedBoard = new string(board);
            Console.Write(updatedBoard);
            Console.WriteLine(" ");
        }





    }
}
