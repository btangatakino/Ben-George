using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> act = new List<Activity>()
        {
            new Running("15th July 2023", 60, "Running", 10)
        };

        foreach (Activity activity in act)
        {
            activity.GetSummary();
        }


    }
}