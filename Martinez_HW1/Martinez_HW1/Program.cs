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
                Console.WriteLine("2. Calculate the volume of a sphere.");
                Console.WriteLine("3. Print values between 0-n that are multiples of 3 or 5.");
                Console.WriteLine("4. Check if the string is a palindrome or not.");
                Console.WriteLine("5. Exit the program.");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine(" ");

                //prompt user for menu choice
                Console.WriteLine("Please enter your menu choice: ");
                menuChoice = int.Parse(Console.ReadLine());

                //handle user choice 
                if (menuChoice == 1)
                {
                    //prompt user for fahrenheit degrees 
                    Console.WriteLine("Enter the degrees in fahrenheit (float): ");
                    float fahrenheit = float.Parse(Console.ReadLine());

                    //convert 
                    float celsius = (fahrenheit - 32) * 5 / 9;

                    //print results 
                    Console.WriteLine("Conversion: {0} degrees fahrenheit is {1} degrees celsius", fahrenheit, celsius);
                    Console.WriteLine(" ");

                }
                else if (menuChoice == 2)
                {
                    //prompt user for radius of sphere
                    Console.WriteLine("Enter the radius of the sphere (float): ");
                    float radius = float.Parse(Console.ReadLine());

                    //calculate 
                    double volume = ((4.0f / 3.0f) * Math.PI * Math.Pow(radius, 3));

                    //print volume 
                    Console.WriteLine("Volume of the sphere: {0}", volume);
                    Console.WriteLine(" ");

                }
                else if (menuChoice == 3)
                {
                    //prompt user for max value n 
                    Console.WriteLine("Enter a maximum integer to check for multiples: ");
                    int maxN = int.Parse(Console.ReadLine());

                    //find the multiples of 3 or 5
                    int three;
                    int five;

                    Console.WriteLine("Multiples of 3 or 5 from 0 - {0} are: ", maxN);

                    for (int i = 0; i <= maxN; i++)
                    {
                        three = i % 3;
                        five = i % 5;

                        if (three == 0 || five == 0)
                        {
                            Console.WriteLine("{0}", i);
                        }

                    }

                    Console.WriteLine("...Printing of multiples complete");
                    Console.WriteLine(" ");

                }
                else if (menuChoice == 4)
                {
                    //prompt user for string 
                    Console.WriteLine("Enter a string to check for a palindrome: ");
                    string word = Console.ReadLine();

                    //determine if string is a palindrome 
                    //call recursive palindrome method 
                    bool check = PalindromeCheck(word);

                    if (check == true)
                    {
                        Console.WriteLine("{0} is a palindrome.", word);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a palindrome.", word);
                        Console.WriteLine(" ");
                    }
                }
                else if (menuChoice != 1 && menuChoice != 2 && menuChoice != 3 && menuChoice != 4 && menuChoice != 5)
                {
                    //print invalid option 
                    Console.WriteLine("Invalid option. Please try again");
                    Console.WriteLine(" ");
                }

            } while (menuChoice != 5);

            //if user chooses 5, exit the program 
            if (menuChoice == 5)
            {
                Console.WriteLine("Thank you. Exiting the program...");
            }
        }

        //recursive method to check if inputted string is a palindrome
        public static bool PalindromeCheck(string word)
        {
            if (word.Length <= 1)
            {
                return true;
            }
            else if (word[0] != word[word.Length - 1])
            {
                //if first and last letters are not the same return false
                return false;
            }
            else
            {
                //call the method again, move down the string
                return PalindromeCheck(word.Substring(1, word.Length - 2));
            }

        }
    }
}
