using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class!");
            bool run = true;
            while (run)
            {
                string[] names = new string[] { "Mike", "Othelle", "Derek", "Mark", "Bruce", "Chuck", "Tallon", "Pete", "Allison", "Josh" };
                string[] hometowns = new string[] { "New Baltimore", "Grand Rapids", "Lansing", "Muskegon", "Kalamazoo", "Detroit", "Battle Creek", "Ann Arbor", "Saginaw", "Grayling" };
                string[] favFoods = new string[] { "pizza", "bagels", "porkchops", "ice cream", "salad", "beans", "soup", "chili", "burritos", "tacos" };

                Console.WriteLine("\nWhat would you like to know about the class? (names/hometowns/favorite foods):");

                string userInput = GetInput();

                switch (userInput)
                {
                    case "names":
                        PrintNames(names);
                        break;

                    case "hometowns":
                        PrintHometowns(names, hometowns);
                        break;

                    case "favorite foods":
                        PrintFavFoods(names, favFoods);
                        break;

                    default:
                        Console.WriteLine("Invalid!");
                        break;
                }
                
                Console.WriteLine("\nGo again? (y/n):");
                run = Continue();
            }
        }

        //Get input and check if it's valid
        public static string GetInput()
        {
            string input = Console.ReadLine().ToLower();
            if (!input.Equals("names") && !input.Equals("hometowns") && !input.Equals("favorite foods"))
            {
                Console.WriteLine("Invalid! Please type names/hometowns/favorite foods:");
                input = GetInput();
            }

            return input;  
        }

        public static void PrintNames(string[] names)
        {
            Console.WriteLine("\nStudents in the class:");
            Console.WriteLine("======================\n");

            //Print out each person's name
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        public static void PrintHometowns(string[] names, string[] hometowns)
        {
            Console.WriteLine("\nStudents' hometowns:");
            Console.WriteLine("====================\n");

            //Print out each person's name and hometown
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " is from " + hometowns[i] + ".");
            }
        }

        public static void PrintFavFoods(string[] names, string[] favFoods)
        {
            Console.WriteLine("\nStudents' favorite foods:");
            Console.WriteLine("=========================\n");

            //Print out each person's name and favorite food
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " likes to eat " + favFoods[i] + ".");
            }
        }

        //Continue program?
        public static bool Continue()
        {
            string input = Console.ReadLine().ToLower();
            bool run = false;

            if (input.Equals("n"))
            {
                Console.WriteLine("Bye!");
                run = false;
            }
            else if (input.Equals("y"))
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Invalid input! Please type y/n:");
                run = Continue();
            }

            return run;
        }
    }
}
