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
            PrintMenu(ref userChoice);

            //handle user input
            if(userChoice == 1)
            {
                //call for video scan
                VideoScan();

            } else if(userChoice == 2)
            {
                //call for audio scan
                AudioScan();

            } else if(userChoice == 3)
            {
                //call for image scan
                ImageScan();

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
                Console.WriteLine("Thank you for using this program. Program has ended.");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }


         }

       //method prints main menu
       public static void PrintMenu(ref int userChoice) {

            Console.WriteLine("Main Menu - Choose an number option: ");
            Console.WriteLine("1. Scan for videos");
            Console.WriteLine("2. Scan for audio");
            Console.WriteLine("3.Scan for images");
            Console.WriteLine("4.Scan for all");
            Console.WriteLine("5. Access video library");
            Console.WriteLine("6. Access audio library");
            Console.WriteLine("7. Access image library");
            Console.WriteLine("8. Close program");
            Console.WriteLine(" ");

            userChoice = int.Parse(Console.ReadLine());

        }

       public static void VideoScan()
        {
            string directory;
            Console.WriteLine("Enter a directory to search for: ");
            directory = Console.ReadLine();

            //get avi file type 
            string avi = FileType.GetName(typeof(FileType), FileType.AVI);
            string fileavi = ("*." + avi.ToLower());

            //get mov file type 
            string mov = FileType.GetName(typeof(FileType), FileType.MOV);
            string filemov = ("*." + mov.ToLower());

            string[] videoTypes = new string[2];
            videoTypes[0] = fileavi;
            videoTypes[1] = filemov;

            //create list to store files
            List<FileInfo> videos = new List<FileInfo>();

            //call recursive function to get files 
            videos = SearchForFile(directory, videoTypes);
        }


      public static void AudioScan()
        {
            string directory;
            Console.WriteLine("Enter a directory to search for: ");
            directory = Console.ReadLine();

            //get wav file type 
            string wav = FileType.GetName(typeof(FileType), FileType.WAV);
            string filewav = ("*." + wav.ToLower());

            //get mp3 file type 
            string mpThree = FileType.GetName(typeof(FileType), FileType.MP3);
            string filempThree = ("*." + mpThree.ToLower());

            //get mp4 file type 
            string mpFour = FileType.GetName(typeof(FileType), FileType.MP4);
            string filempFour = ("*." + mpFour.ToLower());

            string[] audioTypes = new string[3];
            audioTypes[0] = filewav;
            audioTypes[1] = filempThree;
            audioTypes[2] = filempFour;

            //create list to store files
            List<FileInfo> audios = new List<FileInfo>();

            //call recursive function to get files 
            audios = SearchForFile(directory, audioTypes);
        }


       public static void ImageScan()
        {
            string directory;
            Console.WriteLine("Enter a directory to search for: ");
            directory = Console.ReadLine();

            //get jpg file type 
            string jpg = FileType.GetName(typeof(FileType), FileType.JPG);
            string filejpg = ("*." + jpg.ToLower());

            //get png file type 
            string png = FileType.GetName(typeof(FileType), FileType.PNG);
            string filepng = ("*." + png.ToLower());

            string[] imageTypes = new string[2];
            imageTypes[0] = filejpg;
            imageTypes[1] = filepng;

            //create list to store files
            List<FileInfo> picture = new List<FileInfo>();

            //call recursive file finding method
            picture = SearchForFile(directory, imageTypes);
        }

        void VideoLibrary()
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

        void AudioLibrary()
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

        void ImageLibrary()
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



        //method finds files of certain type in folder 
        public static List<FileInfo> SearchForFile(string path, string[] types)
        {

            List<FileInfo> media = new List<FileInfo>();

            foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            {
                try
                {
                    foreach (string s in types)
                    {
                        foreach (FileInfo file in new DirectoryInfo(directory.FullName).GetFiles(s))
                        {
                            Console.WriteLine("Found file: " + file.Name + " in " + file.DirectoryName);

                            string parsedFileName = file.FullName.Split(new char[] { ':' })[1];
                            string parsedFilePath = parsedFileName.Split(new string[] { s },
                                StringSplitOptions.RemoveEmptyEntries)[0];
                            parsedFilePath = parsedFilePath.Remove(parsedFilePath.LastIndexOf("\\"));
                            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + parsedFilePath);
                            File.Copy(file.FullName, AppDomain.CurrentDomain.BaseDirectory + parsedFileName, true);
                            media.Add(file);
                        }
                    }
                    media.AddRange(SearchForFile(directory.FullName, types));
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("No access avaiable to" + directory.FullName);
                }
            }
            return media;
        }







    }
}
