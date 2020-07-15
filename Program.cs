using System;

namespace MyFirstGitHubConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from MyFirstGitHubConsoleApp!");

            // Prompt the user to enter their name
            Console.WriteLine("Please enter your name:");

            // Declare a string variable to hold the users name.
            string strName = string.Empty;

            // Retrieve data from User and store the value in a strName variable.
            strName = Console.ReadLine();

            // Display custom greeting.
            Console.WriteLine($"Hello {strName}, Welcome to the best Console App in the world :) .");

            // Declare and Add 2 Numbers

            int myFirstNumber = 200;
            int mySecondNumber = 10;

            // Print the Total to the Console App
            Console.WriteLine($"myFirstNumber: {myFirstNumber} plus mySecondNumber: {mySecondNumber} = {myFirstNumber + mySecondNumber}");

        }
    }
}
