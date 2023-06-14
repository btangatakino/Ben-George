using System;
using System.Collections.Generic;

public class GeneratePrompt : Activity
{
    private Random random = new Random();
    // List to keep track of the used indexes
    private List<int> usedIndex = new List<int>();
    private List<int> usedIndex2 = new List<int>();
    private List<int> usedIndex3 = new List<int>();
    
    private List<string> questions = new List<string>()
    {
        "How did you feel when it was completed?",
        "What is your favorite thing about this experience?",
        "How would you have reacted differently about this experience?",
        "How would you have rated this experience, 5 is very difficult and 1 not so difficult?",
        "If you were faced with the same expreience again, would you be prepared to face it?",
        "What do you think what Jesus Christ would have done in this situation?"
    };
    private List<string> prompts = new List<string>()
    {
        "--- Think of a time when you did something really difficult. ---",
        "--- Think of a time when you had to overcome your fear of something. ---",
        "--- Think of a time when you had a disagreament with somebody. ---",
        "--- Think of a time how you responded about someones harsh remarks about you. ---"
    };
    private List<string> promptsList = new List<string>()
    {
        "--- When have you felt the Holy Ghost this month? ---",
        "--- When have you been blessed by someone else this month? ---",
        "--- When have you blessed someone else this month? ---"
    };

    public void GenerateReflectQuestion()
    {
        int index;
        do
        {
            index = random.Next(questions.Count);
        }
        while (usedIndex.Contains(index));
        usedIndex.Add(index);
        if (usedIndex.Count == questions.Count)
        {
            usedIndex.Clear();
        }
        Console.WriteLine(questions[index]);
    }
    public void GenerateReflectPrompt()
    
    {
        
        int index2 = random.Next(prompts.Count);
        while (usedIndex2.Contains(index2));
        usedIndex.Add(index2);
        if (usedIndex2.Count == prompts.Count)
        {
            usedIndex2.Clear();
        }
        Console.WriteLine(prompts[index2]);
    }

    public void GeneratePrompsList()
    {
        int index3;
        do
        {
            index3 = random.Next(promptsList.Count);
        }
        while (usedIndex3.Contains(index3));
        usedIndex3.Add(index3);
        if (usedIndex3.Count == promptsList.Count)
        {
            usedIndex3.Clear();
        }
        Console.WriteLine(promptsList[index3]);
    }
}