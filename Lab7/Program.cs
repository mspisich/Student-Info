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
            Console.WriteLine("Welcome to our C# class! (Note: info on students' hometowns and favorite foods is completely made up!)");
            bool run = true;
            while (run)
            {
                List<string> names = new List<string> ();

                names.Add("Mike");
                names.Add("Othelle");
                names.Add("Derek");
                names.Add("Mark");
                names.Add("Bruce");
                names.Add("Chuck");
                names.Add("Tallon");
                names.Add("Pete");
                names.Add("Allison");
                names.Add("Josh");
                
                List<string> hometowns = new List<string>();

                hometowns.Add("New Baltimore");
                hometowns.Add("Grand Rapids");
                hometowns.Add("Lansing");
                hometowns.Add("Muskegon");
                hometowns.Add("Kalamazoo");
                hometowns.Add("Detroit");
                hometowns.Add("Battle Creek");
                hometowns.Add("Ann Arbor");
                hometowns.Add("Saginaw");
                hometowns.Add("Grayling");

                List<string> favFoods = new List<string>();

                favFoods.Add("pizza");
                favFoods.Add("bagels");
                favFoods.Add("porkchops");
                favFoods.Add("ice cream");
                favFoods.Add("salad");
                favFoods.Add("beans");
                favFoods.Add("soup");
                favFoods.Add("chili");
                favFoods.Add("burritos");
                favFoods.Add("tacos");
                
                Console.WriteLine("\nWhich student would you like to know about? Please type a number between 1 and " + names.Count + ", or type 0 for a list of students:");

                int studentChoice = GetStudentChoice(names);

                Console.WriteLine("Student " + studentChoice + " is " + names[studentChoice - 1] + ". What would you like to know about them? (hometown/favorite food):");
  
                //Run while user is curious to learn more
                bool learnMore = true;
                while (learnMore)
                {
                    string infoChoice = GetInfoChoice();
                    switch (infoChoice)
                    {
                        case "hometown":
                            Console.WriteLine(names[studentChoice - 1] + " is from " + hometowns[studentChoice - 1] + ".");
                            break;
                        case "favorite food":
                            Console.WriteLine(names[studentChoice - 1] + " likes to eat " + favFoods[studentChoice - 1] + ".");
                            break;
                        default:
                            Console.WriteLine("Something went wrong... Please try again.");
                            break;
                    }
                    Console.WriteLine("Would you like to learn more about " + names[studentChoice - 1] + "? (y/n)");
                    learnMore = Continue();
                    if(learnMore == true)
                    {
                        Console.WriteLine("What else would you like to know about " + names[studentChoice - 1] + "? (hometown/favorite food)");
                    }
                }




                Console.WriteLine("\nGo again? (y/n):");
                run = Continue();
            }
        }

        //Get input and check if it's a student that exists
        public static int GetStudentChoice(List<string> names)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 0 || input > names.Count)
            {
                Console.WriteLine("That student doesn't exist! Please type a number between 1 and " + names.Count + ", or type 0 for a list of names:");
                input = GetStudentChoice(names);
            }
            else if(input == 0)
            {
                PrintNames(names);
                Console.WriteLine("\nWhich student would you like to know about? Please type a number between 1 and " + names.Count + ", or type 0 for a list of students:");
                input = GetStudentChoice(names);
            }

            return input;  
        }

        public static void PrintNames(List<string> names)
        {
            Console.WriteLine("\nStudents in the class:");
            Console.WriteLine("======================\n");

            int studentIndex = 0;

            //Print out each person's name
            foreach (string name in names)
            {
                studentIndex++;
                Console.WriteLine(studentIndex + ": " + name);
            }
        }

        public static string GetInfoChoice()
        {
            string infoChoice = Console.ReadLine().ToLower();

            //Validate input
            while (!infoChoice.Equals("hometown") && !infoChoice.Equals("favorite food"))
            {
                Console.WriteLine("Please type hometown/favorite food:");
                infoChoice = Console.ReadLine().ToLower();
            }

            return infoChoice;
        }

        public static void PrintHometown (int studentChoice, List<string> names, List<string> hometowns)
        {
            Console.WriteLine(names[studentChoice - 1] + " is from " + hometowns[studentChoice] + ".");
        }

        //Continue program?
        public static bool Continue()
        {
            string input = Console.ReadLine().ToLower();
            bool run = false;

            if (input.Equals("n"))
            {
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
