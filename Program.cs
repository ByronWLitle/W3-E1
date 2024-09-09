using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int conMeth = 0;
            double amount = 0;
            do
            {
                //Prints title of program
                Console.WriteLine("Currency Exchange Program");
                //Divides for better visibility
                Console.WriteLine("");
                //Prompts user to enter an amount they want to exchange
                Console.Write("Enter USD amount: ");
                //Converts user input to variable called "amount" to store as a double
                amount = Convert.ToDouble(Console.ReadLine());
                //Divides for better visibility
                Console.WriteLine("");
                //Gives user options on what to convert to
                Console.WriteLine("1. Convert to YEN");
                Console.WriteLine("2. Convert to EUR");
                Console.WriteLine("3. Convert to INR");
                Console.WriteLine("4. Quit Program");
                //Prompts user to select method
                Console.Write("Select conversion method: ");
                //Converts user input to variable called "conMeth" to store as integer
                conMeth = Convert.ToInt32(Console.ReadLine());
                //Takes variable "conMeth" for each case
                switch (conMeth)
                {
                    case 1:
                        ConvertToYEN(amount);
                        break;
                    case 2:
                        ConvertToEUR(amount);
                        break;
                    case 3:
                        ConvertToINR(amount);
                        break;
                }
            } while (conMeth != 4);

        }
        public static double ConvertToYEN(double amount)
        {
            double retValue = 0;
            double exYEN = 143.18;
            retValue = amount * exYEN;
            Console.WriteLine($"You have {retValue} Japanese Yen from ${amount}");
            return retValue;
        }
        public static double ConvertToEUR(double amount)
        {
            double retValue = 0;
            double exEUR = 0.9;
            retValue = amount * exEUR;
            Console.WriteLine($"You have {retValue} Euros from ${amount}");
            return retValue;
        }
        public static double ConvertToINR(double amount)
        {
            double retValue = 0;
            double exINR = 83.95;
            retValue = amount * exINR;
            Console.WriteLine($"You have {retValue} Indian Rupees from ${amount}");
            return retValue;
        }
    }
}
