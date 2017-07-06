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
            //When would you use a loop?
            //Why would you use a loop?
            //Nested Loops
            //Infinite Loops
            //Keywords break and continue

            //FOR loops, WHILE loops, FOR EACH loops, DO-WHILE loops

            //FOR loops
            //Can be used for both counting and ITERATING through an array(or other collection type)
            //Looks like this:
            //for(initializer; condition; updater)
            //{ do something }

            //int i;
            //for (int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string greeting = "My name is Little Bill.";
            ////The .Split() method takes a string and turns in into an array of smaller strings. it defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split();
            ////for loop to print words
            //for (int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            //Create an array called days with the elements Monday, Tuesday, and Wednesday.
            //Using a For loop, print the elements of the days array.

            //Start with the string "Once upon a time" and create an array called
            //storyWords using the split method. Reverse the order of the elements in
            //the array and using a For loop, print each word

            //Add the product (multiplication) of 1 through 10 using a For loop
            //Print the product to the screen

            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //string story = "Once upon a time...";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords);
            //for (int i=0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //int product = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    product = (product * i);
            //}
            //    Console.WriteLine(product);

            //Foreach loop - used to iterate over a collection (ex. list or array)
            //you can think of the structure of a foreach loop as the statement:
            //for each item in the collection, do something
            // for each(dataType variable in collection)
            // * {
            // * do something
            // * }
            //int[] studentGrades={4,4,3,4,3};
            //foreach(int grade in studentGrades)
            //{ Console.WriteLine(grade);}

            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            ////Always start with the keyword foreach
            //foreach(string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}
            ////foreach loops allow the temporary variable to "know" to assign itself to each
            ////element in the collection(like an array), one at at time.

            ////create an array of 6 musicians(bands or solo artists) using using a foreach loop
            ////print each musicians name

            //string[] musicians = { "Beach Boys", "Beach House", "Beach Fossils", "Dirty Beaches", "Beach Stav", "Meatloaf" };
            //foreach(string bands in musicians)
            //{
            //    Console.WriteLine(bands);
            //}

            //WHILE LOOPS only run when a certain condition is met
            //While something is TRUE, do this thing.

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while (firstName.ToUpper() == "NICK")
            //{
            //    Console.WriteLine("You're amazing!");
            //    break;
            //}

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while(playAgain.ToUpper() == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}
            //While loops can be infinite UNLESS the condition is met, or if you add a break;

            //A DO-WHILE loop is similar to a while loop, however the DO-WHILE loop is used when you want
            //a chunk of code to run at least once, but repeat only if the while condition is met
            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Do you want to play the game? YES/NO");
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play the game? YES/NO");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");

            //Ask the user for the class (in school) that they would like to add to their GPA calculation.
            //Ask the user for the letter grade for the class (no + or -)
            //Ask the user if they have another class they would like to add to their GPA calculation
            //Using a do-while loop, repeat the code if the user says "YES"

            string className;
            string letterGrade;
            string anotherClass;
            do
            {
                Console.WriteLine("Which class would you like to add to your GPA? ");
                className = Console.ReadLine();
                Console.WriteLine("What is your grade? ");
                letterGrade = Console.ReadLine();
                Console.WriteLine("Do you have another class that you would like to add? ");
                anotherClass = Console.ReadLine();


            }
            while (anotherClass.ToUpper() == "YES");
            
            




        }
    }
}
