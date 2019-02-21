using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace HW4_GenericsAndInterfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            int userChoice = 0;
            printMenu(ref userChoice);

            if(userChoice == 1)
            {
                //call videoScan method
            } else if(userChoice == 2)
            {
                //call audioScan method
            } else if(userChoice == 3)
            {
                //call imageScan method
            } else if(userChoice == 4)
            {
                //scan for all media 
            } else if(userChoice == 5)
            {
                //call video library method
            } else if(userChoice == 6)
            {
                //call audio library method
            } else if(userChoice == 7)
            {
                //call image library method
            } else if(userChoice == 8)
            {
                //end the program 
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }


         }

       //method prints main menu
       public static void printMenu(ref int userChoice) {


            Console.WriteLine("Main Menu - Choose an option: ");
            Console.WriteLine("1. Scan for videos");
            Console.WriteLine("2. Scan for audio");
            Console.WriteLine("3.Scan for images");
            Console.WriteLine("4.Scan for all");
            Console.WriteLine("5. Access video library");
            Console.WriteLine("6. Access audio library");
            Console.WriteLine("7. Access image library");
            Console.WriteLine("Close program");
            Console.WriteLine(" ");

            userChoice = int.Parse(Console.ReadLine());

        }

        void videoScan()
        {
            string directory;
            Console.WriteLine("Enter a directory to search for: ");
            directory = Console.ReadLine();



            //ask user for directory to search
            //display message saying: JPG found - C://users/desktop/myjpg.jpg
            //etc
        }


        void audioScan()
        {
            string directory;
            Console.WriteLine("Enter a directory to search for: ");
            directory = Console.ReadLine();

            //ask user for directory to search
            //display message saying: JPG found - C://users/desktop/myjpg.jpg
            //etc
        }


        void imageScan()
        {
            string directory;
            Console.WriteLine("Enter a directory to search for: ");
            directory = Console.ReadLine();

            //ask user for directory to search
            //display message saying: JPG found - C://users/desktop/myjpg.jpg
            //etc
        }

        void videoLibrary()
        {
            int menuChoice;

            Console.WriteLine("------Library Information-------");
            Console.WriteLine("Index: ");
            Console.WriteLine("File name: ");
            Console.WriteLine("File extension: ");
            Console.WriteLine("Date last accessed: ");
            //index
            //file name
            //file extension
            //date last accessed

            Console.WriteLine(" ");
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Sort by name");
            Console.WriteLine("2. Sort by extension");
            Console.WriteLine("3. Sort by date last accessed");
            Console.WriteLine("4. Touch File");     //user inputs an index to touch a file, opened and change date accessed  
            Console.WriteLine("5. Remove file");    //remove the file form the library not disk
            Console.WriteLine("6. Back to main menu");
            menuChoice = int.Parse(Console.ReadLine());

            //if statement handling user input 



      
        }

        void audioLibrary()
        {
            int menuChoice;

            Console.WriteLine("------Library Information-------");
            Console.WriteLine("Index: ");
            Console.WriteLine("File name: ");
            Console.WriteLine("File extension: ");
            Console.WriteLine("Date last accessed: ");
            //index
            //file name
            //file extension
            //date last accessed

            Console.WriteLine(" ");
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Sort by name");
            Console.WriteLine("2. Sort by extension");
            Console.WriteLine("3. Sort by date last accessed");
            Console.WriteLine("4. Touch File");     //user inputs an index to touch a file 
            Console.WriteLine("5. Remove file");    //remove the file form the library not disk
            Console.WriteLine("6. Back to main menu");
            menuChoice = int.Parse(Console.ReadLine());

            //if statement handling user input 
        }

        void imageLibrary()
        {
            int menuChoice;

            Console.WriteLine("------Library Information-------");
            Console.WriteLine("Index: ");
            Console.WriteLine("File name: ");
            Console.WriteLine("File extension: ");
            Console.WriteLine("Date last accessed: ");
            //index
            //file name
            //file extension
            //date last accessed

            Console.WriteLine(" ");
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Sort by name");
            Console.WriteLine("2. Sort by extension");
            Console.WriteLine("3. Sort by date last accessed");
            Console.WriteLine("4. Touch File");     //user inputs an index to touch a file 
            Console.WriteLine("5. Remove file");    //remove the file form the library not disk
            Console.WriteLine("6. Back to main menu");
            menuChoice = int.Parse(Console.ReadLine());

            //if statement handling user input 
        }

    }
}
