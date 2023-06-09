using System;
using System.Collections.Generic;

public class GenerateReflectPrompt : Activity
{
    private Random random = new Random();
    // List to keep track of the used indexes
    public List<int> usedIndex = new List<int>();

    public void GeneratePrompt()
    {
    List<string> reflectPrompt = new List<string>();
    reflectPrompt.Add("How did you feel when it was completed?");
    reflectPrompt.Add("What is your favorite thing about this experience?");
    reflectPrompt.Add("How would you have reacted differently about it?");
    reflectPrompt.Add("How would you have rated this experience, 5 is very difficult and 1 not so difficult?");
    reflectPrompt.Add("If you were faced with the same expreience again, would you be prepared to face it?");
    
    int index;
        do
        {
            index = random.Next(reflectPrompt.Count);
        }
        while(usedIndex.Contains(index));
        usedIndex.Add(index);
        if(usedIndex.Count == reflectPrompt.Count)
        {
            usedIndex.Clear();
        }
    Console.WriteLine(reflectPrompt[index]);
    Console.ReadLine();
    }
    
}
