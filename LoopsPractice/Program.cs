using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loops 
            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            //foreach (String month in months)
            //{
            //    Console.WriteLine(month);
            //    if (month == "Dec")
            //    {
            //        Console.WriteLine("Thats the best month");
            //    }
            //    else
            //    {
            //        Console.WriteLine("That month is ok i guess...");
            //    }
            //}

            //string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            //foreach(string musician in musicians)
            //{
            //    Console.WriteLine(musician);
            //}

            //Create a program that asks the user for there fav food and stores those values in an array.
            //Loop through the array and print all of the foods

            //Create an array of lucky numbers using a foreach loop print the following
            //Your lucky number is: 4
            //Your lucky number is: 19
            //Your lucky number is: 7

            string[] favFoods = new string[3];
            foreach (string food in favFoods) ;
            Console.WriteLine("What is your fav food?");
            Console.ReadLine();
            Console.WriteLine("What is your second favorite food?");
            Console.ReadLine();
            Console.WriteLine("What is your third favorite food?");
            Console.ReadLine();     



            




        }
    }
}
