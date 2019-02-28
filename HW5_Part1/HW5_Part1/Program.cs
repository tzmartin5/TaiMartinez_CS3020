///<summary>Program creates a grade organizer based on semesters each with 5 courses. 
///Users are able to input multiple number of semester to compare and organize grades.
///The program will prompt the user to input the names of the classes, the professor for that class,
///and that class for all 5 classes for each semester.
///Program then will ask the user to choose: 
///1. to find the average of the grades for the semester 
///2. find the highest grade of the semester
///3. find the lowest grade of the semester
///4. find the class information based on a certain professor
///This is the solution without using LINQ
/// </summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfSemesters;
            string semester;

            //declare variables for 5 classes 
            string nameOne = null;
            string nameTwo = null;
            string nameThree = null;
            string nameFour = null;
            string nameFive = null;
            string profOne = null;
            string profTwo = null;
            string profThree = null;
            string profFour = null;
            string profFive = null;
            double gradeOne = 0;
            double gradeTwo = 0;
            double gradeThree = 0;
            double gradeFour = 0;
            double gradeFive = 0;

            int menuChoice = 0;
            
            //prompt user to input number of semester to compare 
            Console.WriteLine("Enter the number of semesters you would like to compare: ");
            numOfSemesters = int.Parse(Console.ReadLine());

          //create collection of the data 
            List<SemesterClass> data = new List<SemesterClass>();

            for (int i = 0; i < numOfSemesters; i++)
            {
                //prompt user for the name of the semester
                Console.WriteLine("Name of the Semester (eg. Fall Third Year): ");
                semester = Console.ReadLine();

                nameOne = UserClassName(nameOne);
                profOne = UserProfName(profOne);
                gradeOne = UserGrade(gradeOne);

                nameTwo = UserClassName(nameTwo);
                profTwo = UserProfName(profTwo);
                gradeTwo = UserGrade(gradeTwo);

                nameThree = UserClassName(nameThree);
                profThree = UserProfName(profThree);
                gradeThree = UserGrade(gradeThree);

                nameFour = UserClassName(nameFour);
                profFour = UserProfName(profFour);
                gradeFour = UserGrade(gradeFour);

                nameFive = UserClassName(nameFive);
                profFive = UserProfName(profFive);
                gradeFive = UserGrade(gradeFive);

                //create list for collection
                //add info to the list 
                data = new List<SemesterClass>();
                data.Add(new SemesterClass { ClassName = nameOne, Professor = profOne, Grade = gradeOne });
                data.Add(new SemesterClass { ClassName = nameTwo, Professor = profTwo, Grade = gradeTwo });
                data.Add(new SemesterClass { ClassName = nameThree, Professor = profThree, Grade = gradeThree });
                data.Add(new SemesterClass { ClassName = nameFour, Professor = profFour, Grade = gradeFour });
                data.Add(new SemesterClass { ClassName = nameFive, Professor = profFive, Grade = gradeFive });

                //print verification information 
                Console.WriteLine("----------------{0} Information Verification---------------", semester);

                //clarify the info is correct
                foreach (SemesterClass item in data)
                {
                    Console.WriteLine("Class: " + item.ClassName + "\tProfessor: " + item.Professor + "\t\tGrade: " + item.Grade + "\n");

                }

                //print menu 
                menuChoice = Menu(menuChoice);

                //declare varaibles for menu
                double large = data[0].Grade;
                double small = data[0].Grade;
                string largeClass = data[0].ClassName;
                string smallClass = data[0].ClassName;

                if (menuChoice == 1)
                {
                     //find the average of the grades 
                     double zero = data[0].Grade;
                     double one = data[1].Grade;
                     double two = data[2].Grade;
                     double three = data[3].Grade;
                     double four = data[4].Grade;

                
                    double average = ((zero + one + two + three + four) / 5);

                    Console.WriteLine("The average is: " + average);
                    Console.WriteLine(" ");
                    
                }
                else if (menuChoice == 2)
                {
                    //find highest grade
                    for(int j = 1; j < 5; j++)
                    {
                        if(data[i].Grade > large)
                        {
                            large = data[i].Grade;
                            largeClass = data[i].ClassName;
                        }
                    }

                    Console.WriteLine("The Highest Grade is a {0} in class {1} ", large, largeClass);
                }
                else if (menuChoice == 3)
                {
                    //find lowest grade 
                    for (int j = 1; j < 5; j++)
                    {
                        if (data[i].Grade < small)
                        {
                            small = data[i].Grade;
                            smallClass = data[i].ClassName;
                        }
                    }

                    Console.WriteLine("The Lowest Grade is a {0} in class {1} ", small, smallClass);
                }
                else if (menuChoice == 4)
                {

                    double profGrade = data[0].Grade;
                    string profClass = data[0].ClassName;

                    //find the grade of a certain class => contains
                    Console.WriteLine("Enter a professor to search for: ");
                    string searchProf = Console.ReadLine();

                    for(int j = 0; j < 5; j++)
                    {
                        if(data[j].Professor == searchProf)
                        {
                            profGrade = data[j].Grade;
                            profClass = data[j].ClassName;
                        }
                    }

                    Console.WriteLine("Professor {0} taught {1} and the grade recieved was {2}", searchProf, profClass, profGrade);

                }
                else if (menuChoice == 5)
                {
                    Console.WriteLine("Thank you for using the program.");
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }

        } //end of main

       
      //stores the names of the class
      public static  string UserClassName(string name)
        {
            //prompt user for the name of the class
            Console.WriteLine("Class Name(eg. C#): ");
            name = Console.ReadLine();

            return name;
        }

     //stores professor name for class
     public static string UserProfName(string prof)
        {
            //prompt user for professor for the class
            Console.WriteLine("Which professor taught the class: ");
            prof = Console.ReadLine();

            return prof;
        }


        //stores grade for the class
        public static double UserGrade(double grade)
        {
            //prompt user for the grade of the class 
            Console.WriteLine("Grade in class: ");
            grade = double.Parse(Console.ReadLine());

            return grade;
        }

        //prints the menu and prompts user to input choice 
       public static int Menu(int menuChoice)
        {

            //print menu 
            Console.WriteLine("*****Comparison Menu****");
            Console.WriteLine("1. Find the average of the grades for the semester");
            Console.WriteLine("2. Find the highest grade");
            Console.WriteLine("3. Find the lowest grade");
            Console.WriteLine("4. Find the information based on a professor ");
            Console.WriteLine("5. Exit the program");

            Console.WriteLine(" ");
            Console.WriteLine("Pick a menu option: ");
            menuChoice = int.Parse(Console.ReadLine());

            return menuChoice;

        }





    } //end of class
} //end of program 
