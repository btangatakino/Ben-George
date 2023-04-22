using System;

class Program
{
    static void Main(string[] args)
    {
        string response4 = "yes";
        while (response4 == "yes")
        {
            Console.Write("What is the magic number? ");
            string response = Console.ReadLine();
            int magicNumber = int.Parse(response);

            /*Console.Write("What is your guess? ");
            string response2 = Console.ReadLine();
            int guess = int.Parse(response2);*/

            int guess = -1;
            int count = 0;
                    
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string response2 = Console.ReadLine();
                guess = int.Parse(response2);

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                count++;                
            }
            Console.WriteLine($"Number of guesses: {count}");
            Console.Write("Do you want to continue? ");
            response4 = Console.ReadLine();
        }
        /*Random randomNumber = new Random();
        int number = randomNumber.Next(1, 101);*/

    }
}