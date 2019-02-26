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

            List<FileInfo> vid = new List<FileInfo>();
            List<FileInfo> aud = new List<FileInfo>();
            List<FileInfo> pic = new List<FileInfo>();

            List<Video> video = new List<Video>();
            List<Audio> audio = new List<Audio>();
            List<Image> image = new List<Image>();

            while (userChoice != 8)
            {
                PrintMenu(ref userChoice);


                //handle user input
                if (userChoice == 1)
                {
                    //call for video scan
                    VideoScan(video);

                }
                else if (userChoice == 2)
                {
                    //call for audio scan
                    AudioScan(ref audio);

                }
                else if (userChoice == 3)
                {
                    //call for image scan
                    ImageScan(image);

                }
                else if (userChoice == 4)
                {
                    //call for all types
                    VideoScan(video);
                    AudioScan( ref audio);
                    ImageScan(image);

                }
                else if (userChoice == 5)
                {
                    //call video library method
                    VideoLibrary<Video>(vid, video);
                }
                else if (userChoice == 6)
                {
                    //call audio library method
                    AudioLibrary<Audio>(aud, audio);


                }
                else if (userChoice == 7)
                {
                    //call image library method
                    ImageLibrary<Image>(pic, image);
                }
                else if (userChoice == 8)
                {
                    Console.WriteLine("Thank you for using this program. Program has ended.");
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }

            }
        }



        //method prints main menu
        public static void PrintMenu(ref int userChoice) {

            Console.WriteLine("Main Menu - Choose an number option: ");
            Console.WriteLine("1. Scan for videos (AVI, MOV)");
            Console.WriteLine("2. Scan for audio (WAV, MP3, MP4)");
            Console.WriteLine("3.Scan for images (JPG, PNG)");
            Console.WriteLine("4.Scan for all (Videos, Audio, and Images) ");
            Console.WriteLine("5. Access video library");
            Console.WriteLine("6. Access audio library");
            Console.WriteLine("7. Access image library");
            Console.WriteLine("8. Close program");
            Console.WriteLine(" ");

            userChoice = int.Parse(Console.ReadLine());

        }

        public static void VideoScan( List<Video> video)
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

            //call recursive function to get files 
              video = SearchForVideo(directory, videoTypes);
        }


        public static void AudioScan( ref List<Audio> audio)
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

            //call recursive function to get files 
            audio = SearchForAudio(directory, audioTypes);
        }


        public static void ImageScan(List<Image> image)
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

            //call recursive file finding method
            image = SearchForImage(directory, imageTypes);
        }

        public static void VideoLibrary<T>(List<FileInfo> video, List<Video> vid)
        {
            int menuChoice;

            Console.WriteLine("------Library Information-------");

            foreach (FileInfo i in video)
            {
                //print index and name
                Console.Write("|{0}|: ", video.IndexOf(i));
                Console.Write("\t" + i);

                //print extentsion
                string ext = i.Extension;
                Console.Write("\t\t\t|" + ext.ToUpper() + "|");

                //print date last acessed 
                DateTime dt = i.LastAccessTime;
                Console.Write("\t\t|Date Last Accessed: {0}|", dt);
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Sort by name");
            Console.WriteLine("2. Sort by extension");
            Console.WriteLine("3. Sort by date last accessed");
            Console.WriteLine("4. Touch File");     //user inputs an index to touch a file, opened and change date accessed  
            Console.WriteLine("5. Remove file");    //remove the file form the library not disk
            Console.WriteLine("6. Back to main menu");

            Console.WriteLine("Enter choice: ");
            menuChoice = int.Parse(Console.ReadLine());

           
            //if statement handling user input 
            if (menuChoice == 1)
            {
                Console.WriteLine("Sorting by name");

                vid.Sort();

                foreach (FileInfo s in video)
                {

                    //print index and name
                    Console.Write("|{0}|: ", video.IndexOf(s));


                    Console.Write("\t" + s);

                    //print extentsion
                    string ext = s.Extension;
                    Console.Write("\t\t\t|" + ext.ToUpper() + "|");

                    //    //print date last acessed 
                    DateTime dt = s.LastAccessTime;
                    Console.Write("\t\t|Date Last Accessed: {0}|", dt);
                    Console.WriteLine(" ");
                }
            }
            else if (menuChoice == 2)
            {
                Console.WriteLine("Sort by Extension");
            }
            else if (menuChoice == 3)
            {
                Console.WriteLine("Sort by date last accessed");
            }
            else if (menuChoice == 4)
            {
                Console.WriteLine("Touch file");
            }
            else if (menuChoice == 5)
            {
                Console.WriteLine("Remove file");
            }
            else if (menuChoice == 6)
            {
                Console.WriteLine("Back to main menu");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }



        }

        public static void AudioLibrary<T>(List<FileInfo> audio, List<Audio> sound) where T : MediaInterface, new()
        {
            int menuChoice;


            Console.WriteLine("------Library Information-------");


            Audio ex = new Audio();

            foreach (FileInfo i in audio)
            {
                Console.WriteLine(ex.File);


                //print index and name
                Console.Write("|{0}|: ", audio.IndexOf(i));
                Console.Write("\t" + ex.File);

               // //print extentsion
                string ext = i.Extension;
               Console.Write("\t\t\t|" + ext.ToUpper() + "|");

               ex.DateAdded = i.LastAccessTime;

                //print date last acessed 
               DateTime dt = i.LastAccessTime;
                Console.Write("\t\t|Date Last Accessed: {0}|", ex.DateAdded);
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("----------Library Menu----------");
            Console.WriteLine("1. Sort by name");
            Console.WriteLine("2. Sort by extension");
            Console.WriteLine("3. Sort by date last accessed");
            Console.WriteLine("4. Touch File");     //user inputs an index to touch a file 
            Console.WriteLine("5. Remove file");    //remove the file form the library not disk
            Console.WriteLine("6. Back to main menu");
            Console.WriteLine("Enter choice: ");
            menuChoice = int.Parse(Console.ReadLine());

            //if statement handling user input 
            if (menuChoice == 1)
            {
                Console.WriteLine("Sorting by name");

                sound.Sort();

                foreach (FileInfo s in audio)
                {

                    //print index and name
                    Console.Write("|{0}|: ", audio.IndexOf(s));


                    Console.Write("\t" + s);

                    //print extentsion
                    string ext = s.Extension;
                    Console.Write("\t\t\t|" + ext.ToUpper() + "|");

                //    //print date last acessed 
                    DateTime dt = s.LastAccessTime;
                    Console.Write("\t\t|Date Last Accessed: {0}|", dt);
                    Console.WriteLine(" ");
                }
            }
            else if(menuChoice == 2)
            {
                Console.WriteLine("Sort by Extension");
            } else if(menuChoice == 3)
            {
                Console.WriteLine("Sort by date last accessed");
            } else if(menuChoice == 4)
            {
                Console.WriteLine("Touch file");
            } else if(menuChoice == 5)
            {
                Console.WriteLine("Remove file");
            }
            else if(menuChoice == 6)
            {
                Console.WriteLine("Back to main menu");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            





        }

        public static void ImageLibrary<T>(List<FileInfo> image, List<Image> picture)
        {
            int menuChoice;

            Console.WriteLine("------Library Information-------");

            foreach (FileInfo i in image)
            {
                //print index and name
                Console.Write("|{0}|: ", image.IndexOf(i));
                Console.Write("\t" + i);

                //print extentsion
                string ext = i.Extension;
                Console.Write("\t\t\t|" + ext.ToUpper() + "|");

                //print date last acessed 
                DateTime dt = i.LastAccessTime;
                Console.Write("\t\t|Date Last Accessed: {0}|", dt);
                Console.WriteLine(" ");
            }

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
            //if statement handling user input 
            if (menuChoice == 1)
            {
                Console.WriteLine("Sorting by name");

                picture.Sort();

                foreach (FileInfo s in image)
                {

                    //print index and name
                    Console.Write("|{0}|: ", image.IndexOf(s));


                    Console.Write("\t" + s);

                    //print extentsion
                    string ext = s.Extension;
                    Console.Write("\t\t\t|" + ext.ToUpper() + "|");

                    //    //print date last acessed 
                    DateTime dt = s.LastAccessTime;
                    Console.Write("\t\t|Date Last Accessed: {0}|", dt);
                    Console.WriteLine(" ");
                }
            }
            else if (menuChoice == 2)
            {
                Console.WriteLine("Sort by Extension");
            }
            else if (menuChoice == 3)
            {
                Console.WriteLine("Sort by date last accessed");
            }
            else if (menuChoice == 4)
            {
                Console.WriteLine("Touch file");
            }
            else if (menuChoice == 5)
            {
                Console.WriteLine("Remove file");
            }
            else if (menuChoice == 6)
            {
                Console.WriteLine("Back to main menu");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }


        //searches for audio 
        static List<Audio> SearchForAudio(string path, string[] types) {

            // List<FileInfo> media = new List<FileInfo>();
            List<Audio> med = new List<Audio>();

            foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            {
                try
                {

                    foreach (string s in types)
                    {

                        foreach (FileInfo file in new DirectoryInfo(directory.FullName).GetFiles(s))
                        {
                            Console.WriteLine("Found file " + file.Name + " in " + file.DirectoryName);

                            string parsedFileName = file.FullName.Split(new char[] { ':' })[1];
                            string parsedFilePath = parsedFileName.Split(new string[] { s },
                                StringSplitOptions.RemoveEmptyEntries)[0];
                            parsedFilePath = parsedFilePath.Remove(parsedFilePath.LastIndexOf("\\"));
                            med.Add( new Audio() { Path = file.FullName});
                        }
                    }

                    med.AddRange(SearchForAudio(directory.FullName, types));
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("No access avaiable to" + directory.FullName);
                }
                
            }
            return med;
        }


        //searches for video 
        static List<Video> SearchForVideo(string path, string[] types)
        {

            // List<FileInfo> media = new List<FileInfo>();
            List<Video> med = new List<Video>();

            foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            {
                try
                {

                    foreach (string s in types)
                    {

                        foreach (FileInfo file in new DirectoryInfo(directory.FullName).GetFiles(s))
                        {
                            Console.WriteLine("Found file " + file.Name + " in " + file.DirectoryName);

                            string parsedFileName = file.FullName.Split(new char[] { ':' })[1];
                            string parsedFilePath = parsedFileName.Split(new string[] { s },
                                StringSplitOptions.RemoveEmptyEntries)[0];
                            parsedFilePath = parsedFilePath.Remove(parsedFilePath.LastIndexOf("\\"));
                            med.Add(new Video() { File = file });

                        }
                    }

                    med.AddRange(SearchForVideo(directory.FullName, types));
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("No access avaiable to" + directory.FullName);
                }
            }
            return med;
        }

        //searches for image 
        static List<Image> SearchForImage(string path, string[] types)
        {

            List<Image> med = new List<Image>();

            foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            {
                try
                {

                    foreach (string s in types)
                    {

                        foreach (FileInfo file in new DirectoryInfo(directory.FullName).GetFiles(s))
                        {
                            Console.WriteLine("Found file " + file.Name + " in " + file.DirectoryName);

                            string parsedFileName = file.FullName.Split(new char[] { ':' })[1];
                            string parsedFilePath = parsedFileName.Split(new string[] { s },
                                StringSplitOptions.RemoveEmptyEntries)[0];
                            parsedFilePath = parsedFilePath.Remove(parsedFilePath.LastIndexOf("\\"));
                            med.Add(new Image() { File = file });
                        }
                    }

                    med.AddRange(SearchForImage(directory.FullName, types));
                    
                }
                
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("No access avaiable to" + directory.FullName);
                }
            }
            return med;



        }




    } 
}
