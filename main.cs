// Created by: Lucas Tyman
// Created on: Apr 2022
//
// This program determines what type of movie you can see

using System;

class Program
{
    public static void Main(string[] args)
    {
        string ageGroup;

        Console.WriteLine("What movie can you see by yourself?");
        Console.WriteLine("");

        void movieTypes()
        {
            Console.WriteLine("Enter the word that is associated with your age");
            Console.WriteLine("Don't type anything if none of the age groups applies to you.");
            Console.WriteLine("");
            Console.WriteLine("17 years old and up (Adult)");
            Console.WriteLine("13 - 16 years old (Teen)");
            Console.WriteLine("5 - 12 years old (Child)");
            ageGroup = Console.ReadLine();

            if (ageGroup == "Adult")
            {
                Console.WriteLine("You can see a R rated movie alone.");
            }
            else if (ageGroup == "Teen")
            {
                Console.WriteLine("You can see a PG-13 rated movie alone.");
            }
            else if (ageGroup == "Child")
            {
                Console.WriteLine("You can see a G or PG rated movie alone.");
            }
            else
            {
                Console.WriteLine("You are too young too watch a movie alone. Sorry!");
            }
        }

        movieTypes();
        Console.WriteLine("\nDone.");
    }
}