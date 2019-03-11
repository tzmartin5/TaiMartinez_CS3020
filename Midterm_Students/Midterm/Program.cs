using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuSelection = 0;
            VendingMachine machine = new VendingMachine();

        Start:
            do
            {
                Console.WriteLine("Please enter an integer for the option you want to select:");
                Console.WriteLine("1. Print vending machine.");
                Console.WriteLine("2. List only healthy food and drink.");
                Console.WriteLine("3. List toy options for kids under 7.");
                Console.WriteLine("4. Exit Program");

                //handles invalid character input 
                try
                {
                    menuSelection = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Character.Try again with a number 1-4");
                    goto Start;
                }

                List<VendingMachineOption> exclusions = new List<VendingMachineOption>();

                switch (menuSelection)
                {
                    case 1:
                        machine.PrintVendingMachine(new List<VendingMachineOption>());
                        break;
                    case 2:



                        foreach (VendingMachineOption o in machine)
                        {

                            if (o is Food || o is Drink)
                            {
                                if ((o as Food)?.CalorieCount > 100 || (o as Drink)?.CalorieCount > 100)
                                {
                                    exclusions.Add(o);
                                }
                            }
                            else
                            {
                                exclusions.Add(o);
                            }
                        }
                        machine.PrintVendingMachine(exclusions);
                        break;
                    case 3:
                        foreach (VendingMachineOption o in machine)
                        {
                            if (o is NonElectronic || o is Electronic)
                            {
                                if ((o as NonElectronic)?.AgeRequirement >= 7 || (o as Electronic)?.AgeRequirement >= 7)
                                {
                                    exclusions.Add(o);
                                }
                            }
                            else
                            {
                                exclusions.Add(o);
                            }
                        }
                        machine.PrintVendingMachine(exclusions);
                        break;
                    case 4:
                        Console.WriteLine("Thankyou for using this program!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid Number. Please try again");
                        break;
                }
            } while (menuSelection != 4);
        }

       

        static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
