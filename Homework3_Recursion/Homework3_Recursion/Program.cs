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


        static FileInfo GetFiles(string folder, string fileType)
        {

            //create list to hold files 
            List<string> files = new List<string>();

           string newPath = AppDomain.CurrentDomain.BaseDirectory + "\\" + "CopiedFolder";

            foreach (DirectoryInfo directory in new DirectoryInfo(folder).GetDirectories())
            {
                foreach (FileInfo file in new DirectoryInfo(directory.FullName).GetFiles(fileType))
                {
                    Console.WriteLine("Found " + file.Name + " in " + directory.FullName);

                    //add each file name to the list 
                    files.Add(file.Name);

                    //create the directory if it doesn't exist
                    foreach (string i in files)
                    {
                        if (!Directory.Exists(newPath))
                        {
                            Directory.CreateDirectory(newPath);
                        }

                    }

                    //copy all the specific files to the folder 
                    File.Copy(directory.FullName + "\\" + file.Name, newPath + "\\" + file.Name, true);
                }
                if ((f = GetFiles(directory.FullName, fileType)) != null) 
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


            GetFiles(userFolder, fileType);

        }
    }
}
