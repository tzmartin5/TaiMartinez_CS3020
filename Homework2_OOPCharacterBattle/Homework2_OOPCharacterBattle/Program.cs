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

            //handle player one input and create new instances of character 
            if(playerOne == 'm')
            {
                Mage pOneMage = new Mage();

                Console.WriteLine("Move Speed is: {0}", pOneMage.Moves);
                Console.WriteLine("Damage per attack is {0}", pOneMage.SetDamage);




            }
            else if(playerOne == 'w')
            {
               Character pOneWarrior = new Warrior();
            } else if(playerOne == 'a')
             {
                Character pOneArcher = new Archer();
            }

            //handle player two input and create new instances of character 
            if (playerTwo == 'm')
            {
               Mage pTwoMage = new Mage();
            }
            else if (playerTwo == 'w')
            {
               Character pTwoWarrior = new Warrior();
             }
            else if (playerTwo == 'a')
            {
              Character pTwoArcher = new Archer();
             }




            

            //print player health points 


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

            //loop until health points = 0; 







        }   
    }
}
