using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultp
{
    class Program
    {
        static void Main(string[] args)
        {
            cars newcar1 = new cars();
        start:
            bool endapp = false;
            while (!endapp) //to keep the app open and loop until directed to stop
            {
                Console.WriteLine("Enter a car make: ");
                string make = Console.ReadLine(); //will be ignored
                Console.WriteLine("Enter a car Model: ");
                string model = Console.ReadLine();//will be ignored
                Console.WriteLine("Enter the Year the car was made: ");
                int year = Convert.ToInt32(Console.ReadLine()); //The restricted range is between 2016 and 2040.
                if (year > 2040 || year < 2016)
                {
                    Console.WriteLine("This is out of range my friends. Try again!");
                    goto start;
                }
                newcar1.Car1(make, model, year);
                Console.Write("Press 'e' to close the app, or press any other key to make another Tesla: ");
                if (Console.ReadLine() == "e")
                {
                    endapp = true; //Added to change endApp to True to exit
                }
                Console.Clear();
            }
            
        }
    }
}
