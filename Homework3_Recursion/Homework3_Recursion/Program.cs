using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Homework3_Recursion
{
    class Program
    {

        //sets the f to null 
        static FileInfo f = null;


        static FileInfo GetFiles(string fileString)
        {



            foreach (DirectoryInfo directory in new DirectoryInfo(fileString).GetDirectories())
            {
                foreach (FileInfo file in new DirectoryInfo(directory.FullName).GetFiles())
                {
                    Console.WriteLine("Found file in " + directory.FullName);
                    return file; //instead of return create a list of file 
                }
                if ((f = GetFiles(directory.FullName)) != null)
                    return f;

            }

            return f;

        }









        static void Main(string[] args)
        {

            string fileType;
            string userFolder;

            //prompt user to enter type of file to search for 
            Console.WriteLine("Enter the type of file you would like to search for: ");
            fileType = Console.ReadLine();

            //prompt user to enter directories to search in 
            Console.WriteLine("Enter the directories you would like to search: ");
            userFolder = Console.ReadLine();


            string path = AppDomain.CurrentDomain.BaseDirectory + userFolder;

            GetFiles(path);



        }
    }
}
