//author:BHSV
//date:3-2-21
using System;

namespace readline
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            // If we dont write ToInt32 integer input turns into string to avoid this we will write convert code
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
        }
    }
}