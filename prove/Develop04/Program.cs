using System;

class Program
{
    static void Main(string[] args)
    {
        static string DisplayMenu()
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        string userInput = "";

        while (userInput != "4")
        {
            userInput = DisplayMenu();
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity b = new BreathingActivity();
                    b.DisplayBreathe();
                    
                    for (int t = 3; t > 0; t--)
                    {
                        b.BreatheIn();
                        b.BreatheOut();
                        Console.WriteLine(t);
                    }
                    b.DisplayEndMessage();
                    b.GetEndMessage();
                    break;

                case "2":
                    Console.Clear(); 
                    ReflectingActivity r = new ReflectingActivity();
                    r.DisplayReflect();
                    break;

                case "3":
                    Console.Clear();
                    ListingActivity l = new ListingActivity();
                    l.DisplayListing();
                    break;

                case "4":
                    Console.WriteLine("Thank you!");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    break;
            }
        }   
        /*static void GetReadySpinner()
        {
            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            DateTime startTime = DateTime.Now;;
            DateTime endTime = startTime.AddSeconds(10);

            int i = 0;

            while (DateTime.Now < endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                i++;

                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }
        }*/
    }
}