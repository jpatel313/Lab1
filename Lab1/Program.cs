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
            Console.WriteLine("Welcome to the Room Area & Perimeter Generator! \n \nWe will start with the dimensions for Room 1...");
            
            string prompt = "y";

            int x = 1;

            //Run every time user enters y
            while (prompt == "y")
                {
                double length;
                Console.Write("\nPlease enter the LENGTH of Room {0}: ", x);
                
                //Validate input is a number
                if (!double.TryParse(Console.ReadLine(), out length))
                Console.WriteLine("Your input was invalid");

                Console.Write("\nPlease enter the WIDTH of Room {0}: ", x);

                double width;
                if (!double.TryParse(Console.ReadLine(), out width))
                Console.WriteLine("Your input was invalid");

                //Call Method
                Area(length, width, x);

                //Update room number every time user continues.
                x += 1;
                
                //Give user option to continue
                Console.Write("\nDo you want to continue?(y/n): ");
                prompt = Convert.ToString(Console.ReadLine()).ToLower();
                }
            
            //User does not want to continue + validation
            if (prompt == "n" && prompt.Length < 2 && prompt.Length > 0)
                {
                Console.WriteLine("Exiting program now...");
                }
           //If user inputs anything other than y/n
            else
            {
                Console.WriteLine("Your input was invalid, Exiting program now...");
                Console.ReadLine();
            }     
        }


      //Method to calculate area
        public static void Area(double length, double width, int x)
        {
            double area = length * width;

            double perim = 2 * (length + width);
            if (area > 0)
            {
                Console.WriteLine($"\nThe area of Room {x} is: " + area);

                Console.WriteLine($"\nThe perimeter of Room {x} is: " + perim);
            }
            else
                Console.WriteLine("One or more inputs were invalid");
            }
        }
}
