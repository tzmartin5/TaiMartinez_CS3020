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
            char pOne;
            char pTwo;


            //prompt player 1 for character choice 
            Console.WriteLine("Player 1, what class do you choose? m,w,a: ");
            pOne = char.Parse(Console.ReadLine());

            //prompt player 2 for character choice 
            Console.WriteLine("Player 2, what class do you choose? m,w,a: ");
            pTwo = char.Parse(Console.ReadLine());

            Character playerOneM = new Mage();
            Character playerOneW = new Warrior();
            Character playerOneA = new Archer();
            Character playerTwoM = new Mage();
            Character playerTwoW = new Warrior();
            Character playerTwoA = new Archer();
           

            //print inital board
            printBoard(23, 28);

            if (pOne == 'm')
            {

                //print player health points 
                     Console.Write("Player 1 HP: {0} -", playerOneM.CharacterHealth());


                //handle player two input and create new instances of character 
                if (pTwo == 'm')
                {

                    //print player health points 
                    Console.Write("Player 2 HP: {0} ", playerTwoM.CharacterHealth());
                }
                else if (pTwo == 'w')
                {

                    //print player health points 
                    Console.Write("Player 2 HP: {0} ", playerTwoW.CharacterHealth());
                }
                else if (pTwo == 'a')
                {

                    //print player health points 
                    Console.Write("Player 2 HP: {0} ", playerTwoA.CharacterHealth());
                }




            }
            else if(pOne == 'w')
            {

                //print player health points 
                Console.Write("Player 1 HP: {0} -", playerOneW.CharacterHealth());

                //handle player two input and create new instances of character 
                if (pTwo == 'm')
                {

                    //print player health points 
                    Console.Write("Player 2 HP: {0} ", playerTwoM.CharacterHealth());
                }
                else if (pTwo == 'w')
                {

                    //print player health points 
                    Console.Write("Player 2 HP: {0} ", playerTwoW.CharacterHealth());
                }
                else if (pTwo == 'a')
                {

                    //print player health points 
                    Console.Write("Player 2 HP: {0} ", playerTwoA.CharacterHealth());
                }



            }
            else if(pOne == 'a')
             {

                //print player health points 
                Console.Write("Player 1 HP: {0} -", playerOneA.CharacterHealth());

                //handle player two input and create new instances of character 
                if (pTwo == 'm')
                {

                    //print player health points 
                    Console.Write("Player 2 HP: {0} ", playerTwoM.CharacterHealth());
                }
                else if (pTwo == 'w')
                {

                    //print player health points 
                    Console.Write("Player 2 HP: {0} ", playerTwoW.CharacterHealth());
                }
                else if (pTwo == 'a')
                {

                    //print player health points 
                    Console.Write("Player 2 HP: {0} ", playerTwoA.CharacterHealth());
                }


            }

            int playerMage = playerOneM.CharacterPriority();
            int playerWarrior = playerOneW.CharacterPriority();
            int playerArcher = playerOneA.CharacterPriority();

            if(pOne == 'a')
            {
                //print go first 
                Console.WriteLine("Player 1, what do you choose to do?");


            } else if(pOne == 'w')
            {
                //go last 
                Console.WriteLine("Player 2, what do you choose to do?");

            } else if(pOne == 'm' && pTwo == 'a'){
                //go last 
                Console.WriteLine("Player 2, what do you choose to do?");

            } else if(pOne == 'm' && pTwo == 'w')
            {
                //go first 
                Console.WriteLine("Player 1, what do you choose to do?");
            }

            Console.WriteLine(" ");
            Console.Write("1. Move and attack");

            if (pOne == 'm')
            {
                Console.WriteLine(playerOneM.GetMovementAttackDescription(playerOneM.MovesSpeed(), playerOneM.CharacterAttackRange(), playerOneM.Damages()));
                Console.Write("2. Special ");
                Console.WriteLine(playerOneM.GetSpecialDescription());

            }
            else if (pOne == 'w')
            {
                Console.WriteLine(playerOneW.GetMovementAttackDescription(playerOneW.MovesSpeed(), playerOneW.CharacterAttackRange(), playerOneM.Damages()));
                Console.Write("2. Special ");
                Console.WriteLine(playerOneW.GetSpecialDescription());
            }
            else if (pOne == 'a')
            {
                Console.WriteLine(playerOneA.GetMovementAttackDescription(playerOneA.MovesSpeed(), playerOneA.CharacterAttackRange(), playerOneM.Damages()));
                Console.Write("2. Special ");
                Console.WriteLine(playerOneA.GetSpecialDescription());
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
