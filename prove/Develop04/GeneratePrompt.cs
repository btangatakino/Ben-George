using System;
using System.Collections.Generic;

public class GeneratePrompt : Activity
{
    private Random random = new Random();
    // List to keep track of the used indexes
    private List<int> usedIndex = new List<int>();
    private List<int> usedIndex2 = new List<int>();
    private List<int> usedIndex3 = new List<int>();
    
    private List<string> reflectQuestions = new List<string>()
    {
        "\nHow did you feel when it was completed? ",
        "\nWhat is your favorite thing about this experience? ",
        "\nHow would you have reacted differently about this experience? ",
        "\nHow would you have rated this experience, 5 is very difficult and 1 not so difficult? ",
        "\nIf you were faced with the same expreience again, would you be prepared to face it? ",
        "\nWhat do you think Jesus Christ would have done in this situation? "
    };
    private List<string> reflectPrompts = new List<string>()
    {
        "--- Think of a time when you did something really difficult. ---",
        "--- Think of a time when you had to overcome your fear of something. ---",
        "--- Think of a time when you had a disagreament with somebody. ---",
        "--- Think of a time how you responded about someones harsh remarks about you. ---"
    };
    private List<string> listPrompts = new List<string>()
    {
        "--- When have you felt the Holy Ghost this month? ---",
        "--- When have you been blessed by someone else this month? ---",
        "--- When have you blessed someone else this month? ---",
        "--- "
    };

    public void GenerateReflectQuestion()
    {
        int index;
        do
        {
            index = random.Next(reflectQuestions.Count);
        }
        while (usedIndex.Contains(index));
        usedIndex.Add(index);
        if (usedIndex.Count == reflectQuestions.Count)
        {
            usedIndex.Clear();
        }
        Console.Write(reflectQuestions[index]);
    }
    public void GenerateReflectPrompt()    
    {
        int index2 = random.Next(reflectPrompts.Count);
        while (usedIndex2.Contains(index2));
        usedIndex.Add(index2);
        if (usedIndex2.Count == reflectPrompts.Count)
        {
            usedIndex2.Clear();
        }
        Console.WriteLine(reflectPrompts[index2]);
    }

    public void GeneratePrompsList()
    {
        int index3;
        do
        {
            index3 = random.Next(listPrompts.Count);
        }
        while (usedIndex3.Contains(index3));
        usedIndex3.Add(index3);
        if (usedIndex3.Count == listPrompts.Count)
        {
            usedIndex3.Clear();
        }
        Console.WriteLine(listPrompts[index3]);
    }
}