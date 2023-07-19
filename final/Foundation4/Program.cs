using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> act = new List<Activity>()
        {
            new Running("15th July 2023", 60, "Running", 10),
            new Cycling("12th July 2023", 30, "Cycling", 40),
            new Swimming("13th July 2023", 30, "Swimming", 20)
        };

        foreach (Activity activity in act)
        {
            activity.GetSummary();
        }
    }
}