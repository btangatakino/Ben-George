using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 11);

        string response;

        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}