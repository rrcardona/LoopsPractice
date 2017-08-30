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
            //string[] favFoods = new string[3];
            //Console.WriteLine("What is your favorite food?");
            //favFoods[0] = Console.ReadLine();
            //Console.WriteLine("What is your second favorite food?");
            //favFoods[1] = Console.ReadLine();
            //Console.WriteLine("What is your third favorite food?");
            //favFoods[2] = Console.ReadLine();
            //foreach(string food in favFoods)
            //{
            //    Console.WriteLine(food);
            //}

            //int[] luckyNumbers = { 2, 4, 25 };
            //foreach(int number in luckyNumbers)
            //{
            //    Console.WriteLine("Your lucky number is: " +number);
            //}


            //string[] Names = { "Jordan", "Max", "Peter" };
            //for(int i = 0; i<Names.Length; i++)
            //{
            //    Names[i] = Names[i].ToLower();
            //    Console.WriteLine(Names[i]);
            //}

            //for (int counter = 1; counter <= 10; counter+=2)
            //{
            //    Console.WriteLine(counter);
            //}

            //string words = "I like cake";
            //foreach(char letter in words)
            //{
            //    Console.WriteLine(letter);
            //}

            //string greetings = "My name is Ricardo";
            //string[] words = greetings.Split();
            //for(int i =0; i<words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //    if(words[i] =="Ricardo")
            //    {
            //        words[i] = "Max";
            //    }
            //   
            //}
            //Console.WriteLine(words[words.Length - 1]);


            //Create an array called days with the elements monday tuesday etc...
            //Use a for loop to print the elements to the console.

            //Create an int array size 25 put the numbers 0 to 25 in the array and print those numbers to the console

            //Start with the string "Once upon a time" and create an array called storyWords using
            //the split method. Reverse the order of the elements in the array and using a for loop,
            //print each word

            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //int[]numbers = new int [26];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i;
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine(numbers[numbers.Length-1]);

            //string story = "Once upon a time";
            //string[] storyWords = story.Split();
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            // ***while loops***

            //Console.WriteLine("Do you want to play a game?");
            //string playAgain = Console.ReadLine();
            //while(playAgain == "Yes")
            //{
            //    Console.WriteLine("It's a rematch");
            //    Console.WriteLine("Do you want to play again?");
            //    playAgain = Console.ReadLine();
            //}

            //Console.WriteLine("What is your favorite ROYGBIV color?");
            //string userColor = Console.ReadLine();
            ////bool isRoygbivColor = false;
            //while (userColor !="red")
            //{
            //    Console.WriteLine("Sorry. That is not the correct color. Please try again");
            //    userColor = Console.ReadLine();
            //}



            // ***do while loops***

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Do you want to build a snowman?");
            //    Console.WriteLine("That was fun!");
            //    Console.WriteLine("Do you want to build another snowman?");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "yes");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                    {
                    break;
                    }
            }





        }
    }
}
