using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            int menuChoice;

            //loop the menu 
            do
            {
                //print menu 
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Choose an option to perform an action below");
                Console.WriteLine("1. Convert Fahrenheit to Celsius.");
                Console.WriteLine("2. Calculate Volumne of a sphere.");
                Console.WriteLine("3. Print values between 0-n that are multiple of 3 or 5.");
                Console.WriteLine("4. Check if the string is a palindrome.");
                Console.WriteLine("5. Exit the program.");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine(" ");

                //prompt user for menu choice
                Console.WriteLine("Please enter your menu choice: ");
                menuChoice = int.Parse(Console.ReadLine());

                //handle user choice 
                if(menuChoice == 1)
                {
                    //convert degrees 
                } else if(menuChoice == 2)
                {
                    //calcuate volume 
                } else if(menuChoice == 3)
                {
                    //print multiples of 3 or 5
                } else if(menuChoice == 4)
                {
                    //find if palindrome 
                }
                else
                {
                    //print invalid option 
                }








            } while (menuChoice!= 5);

            //if user chooses 5, exit the program 
            if(menuChoice == 5)
            {
                Console.WriteLine("Thank you. Exiting the program...");
            } 




        }
    }
}
