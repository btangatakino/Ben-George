using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade in %? ");
        string gradeInPercentage = Console.ReadLine();
        int number = int.Parse(gradeInPercentage);

        if (number < 60)
        {
            Console.WriteLine("Your grade is F");
        }
        else if (number >= 60 && number < 70)
        {
            Console.WriteLine("Your grade is D");
        }
        else if (number >=70 && number < 80)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (number >=80 && number < 90)
        {
            Console.WriteLine("Your grade is B");
        }
        else
        {
            Console.WriteLine("Your grade is A");
        }
        
    }
}