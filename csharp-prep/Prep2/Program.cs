using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade in percentange? ");
        string response = Console.ReadLine();
        int percentage = int.Parse(response);

        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }

        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 70)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");

        if (percentage <= 70);
        {
            Console.WriteLine("You have passed. Congratulations!");
        }
        else
        {
            Console.WriteLine("Don't give up! Try again!");
        }
        
    }
}