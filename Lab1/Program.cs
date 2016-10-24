using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find area & perimeter of Room 1, get user inputs length and width 
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator! \n We will start with the dimensions for Room 1...");
            Console.WriteLine("Please enter the length of room 1: ");
            string length1 = Console.ReadLine();

            //convert input string to double
            double lengthOne = Convert.ToDouble(length1);

            Console.WriteLine("Please enter the width of room 1: ");
            string width1 = Console.ReadLine();
            double widthOne = Convert.ToDouble(width1);

            //calc area and perimeter then display
            double area1 = lengthOne * widthOne;
            double perim1 = 2 * (lengthOne + widthOne);
            Console.WriteLine("The area of Room 1 is: " + area1);
            Console.WriteLine("The perimeter of Room 1 is: " +  perim1 );
            
            //Give user option to continue
            Console.Write("Do you want to continue?(y/n): " );
            string prompt = Console.ReadLine();

            //When user answers yes, find area & perimeter of Room 2
            if (prompt == "y")

            {
                Console.WriteLine("Please enter the length of Room 2: ");

                string length2 = Console.ReadLine();
                double lengthTwo = Convert.ToDouble(length2);

                Console.WriteLine("Please enter the width of Room 2: ");
                string width2 = Console.ReadLine();
                double widthTwo = Convert.ToDouble(width2);

                double area2 = lengthTwo * widthTwo;
                double perim2 = 2 * (lengthTwo + widthTwo);
                Console.WriteLine("The area of Room 2 is: " + area2);
                Console.WriteLine("The perimeter of Room 2 is: " + perim2);
            }
                //User does not want to continue:
             else
                Console.WriteLine("Exiting program now...");
        }
    }
}
