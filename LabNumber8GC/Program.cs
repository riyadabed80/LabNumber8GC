using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8GC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Racheal", "Anna", "Sarah", "Tim", "Jasmine", "Riyad", "Michael", "Anthony", "Toni", "Jason", "Dr. K", "Mike", "Kim", "Kamesha", "Char", "Cody", "Yasmine", "Dana", "Danielle", "Edwin" };
            string[] Hometown = { "Uganda", "Detroit", "Troy", "Dearborn", "Rochester Hills", "Southwest Detroit", "Westland", "Garden City", "Canton", "Plymouth", "River Rouge", "Eastpointe", "St. Clair Shores", "Lincoln Park", "Allen Park", "Chicago", "New York", "Los Angeles", "Seattle", "Miami" };
            string[] FavFood = { "Pizza", "Hamburgers", "Mac & Cheese", "Chicken", "Salad", "Steak", "Salmon", "Hot Dogs", "Lobster", "Tacos", "Spaghetti", "Shawarma", "Lasagna","French Fries","Chocolate Ice Cream","Salmon","Hunan Chicken","Curry Chicken","Subway","Lava Cake"};
            
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?(Enter a number 1-20):");
            int nameInput;
            while (!int.TryParse(Console.ReadLine(), out nameInput) || nameInput < 1 || nameInput > 20)
            {
                Console.WriteLine("Invalid input. Please enter number between 1 and 20.");
            }
            bool UserContinue = true;
            while (UserContinue)
            {
                Console.WriteLine("Student " + nameInput + " is " + Names[nameInput - 1] + ". What would you like to know about " + Names[nameInput - 1] + "? (enter \"Hometown\" or \"Favorite Food\")");
                string choice1 = Console.ReadLine();
                if (choice1.ToLower().Contains("hometown"))
                {
                    Console.WriteLine(Hometown[nameInput - 1]);
                    UserContinue = false;
                }
                else if (choice1.ToLower().Contains("favorite food"))
                {
                    Console.WriteLine(FavFood[nameInput - 1]);
                    UserContinue = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
                

            }
        }

            
    }
}
