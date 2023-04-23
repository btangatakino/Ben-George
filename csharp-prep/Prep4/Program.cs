using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*string confirm;
        do
        {*/
            List<int> numbers = new List<int>();

            int number = -1;
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            while (number != 0)
            {
                Console.Write("Enter number: ");
                string response = Console.ReadLine();
                number = int.Parse(response);
                numbers.Add(number);
            }
            numbers.Remove(0); //to remove the 0 in the list
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            //sum or total of the numbers in the list
            int total = numbers.Sum();
            Console.WriteLine($"The sum is {total}");

            double average = numbers.Average();
            Console.WriteLine($"The average is {average}");

            int maxNum = numbers.Max();
            Console.WriteLine($"The largest number is {maxNum}");
            
            /*Console.WriteLine("Do you want to enter a new list? Yes / No");
            Console.ReadLine().ToLower();
        }
        while (confirm == "yes");*/
        
    }
    }
