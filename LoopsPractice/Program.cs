﻿using System;
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

            //Foreach loop -used to iterate over a collection(ex.list or array)
            //you can think of the structure of a foreach loop as the statement:
            //for each item in the collection, do something
            // for each(dataType variable in collection)
            // * {
            //    * do something
            //    * }
            //int[] studentGrades = { 4, 4, 3, 4, 3 };
            //foreach (int grade in studentGrades)
            //{ Console.WriteLine(grade); }

            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            ////Always start with the keyword foreach
            //foreach (string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}
            //foreach loops allow the temporary variable to "know" to assign itself to each
            //element in the collection(like an array), one at at time.

            ////create an array of 6 musicians(bands or solo artists) using using a foreach loop
            ////print each musicians name

            //string[] musicians = { "Beach Boys", "Beach House", "Beach Fossils", "Dirty Beaches", "Beach Stav", "Meatloaf" };
            //foreach (string bands in musicians)
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

            //string className;
            //string letterGrade;
            //string anotherClass;
            //do
            //{
            //    Console.WriteLine("Which class would you like to add to your GPA? ");
            //    className = Console.ReadLine();
            //    Console.WriteLine("What is your grade? ");
            //    letterGrade = Console.ReadLine();
            //    Console.WriteLine("Do you have another class that you would like to add? ");
            //    anotherClass = Console.ReadLine();
            //}
            //while (anotherClass.ToUpper() == "YES");

            //NESTED LOOPS
            //Loop inside of another loop
            //The inner loop is executed more times than the outer loop
            //Example: Clock

            //Create a nested loop structure that prints:
            //1234
            //1234

            //for (int rows = 1; rows <= 2; rows++) 
            //{
            //    for (int columns = 1; columns <= 4; columns++) 
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            //Print a triangle
            //Outer loop will go line by line
            //The inner loop will go over different elements in the line.
            //Result:
            //1
            //12
            //123
            //1234

            ////RESULT
            //for (int rows = 1; rows <= 25; rows++)
            //{
            //    for (int columns = 1; columns <= rows; columns++)
            //    {
            //        Console.Write(columns);

            //    }
            //    Console.WriteLine();
            //}

            //PRACTICE PROBLEMS

            ////1
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Hello world.");
            //}

            ////2
            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////3
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i * i);
            //}

            ////4
            //Console.WriteLine("Please enter your favorite weekend activity.");
            //string userResponse = Console.ReadLine();
            //int vowels = 0;
            //foreach (char letter in userResponse)
            //{
            //    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //    {
            //        vowels += 1;
            //    }
            //}
            //Console.WriteLine(vowels);
            ////Different way
            //string[] faveMovies = { "Star Wars", "Anchorman", "Avatar", "Serenity", "Super Troopers" };
            //foreach (string movie in faveMovies)
            //{
            //    if (movie.StartsWith("A"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("E"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("I"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("O"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("U"))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(movie);
            //    }

            ////5
            ////FOR Loop
            //int[] tenNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            ////FOR EACH Loop
            //int[] tenNumbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach(int numbers in tenNumbers2)
            //{
            //    Console.WriteLine(numbers);
            //}

            ////6
            //string variableName = "This is a string";
            //string[] variableSplit = variableName.Split();
            //for (int i = 0; i < variableSplit.Length; i++)
            //{
            //    Console.WriteLine(variableSplit[i]);
            //}

            //MULTIPLICATION TABLE

            //int multNum = 1;
            //Console.WriteLine("Enter in your first number: ");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter in your second number: ");
            //int secondNumber = int.Parse(Console.ReadLine());
            //for (int i=1; i<=firstNumber; i++)
            //{
            //    for (int j = 1; j <= secondNumber; j++)
            //    {
            //        Console.Write(multNum * j + " ");

            //    }
            //    multNum += 1;
            //    Console.WriteLine();
            //}

            //I need to ask the user for an integer, and get the input, and save it
            //"Evenly divisible" is a good indicator of modulus
            //We have to check if the input % 3 ==0
            //We need a conditional and if the input % 3==0 we need to write "You won!"
            //then exit the loop
            //if their input % 3 does not equal 0, let them know, "You lost"
            //and ask for another integer. we repeat this until they win.

            Console.WriteLine("Please enter an integer (whole number).");
            int userNum = int.Parse(Console.ReadLine());

            for (int i=1; i <= userNum; i++)
            {
                if (i %3 == 0)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost!");
                    Console.WriteLine("Please enter another integer");

                }
            }














        }
    }
}

