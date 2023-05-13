using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class PromptGenerator
{
    List<string> _prompts = new List<string>()
    {
        "What is one memorable thing that happened today?",
        "Share an experience of Service today.",
        "Did you speak kind words to someone today?",
        "How have you seen the Lord's hand in your life today?",
        "Name an interesting person you met today and how?"
    };

    Random R = new Random();

    public void GeneratePrompt()
    {
        int someRandomNumber = R.Next(0, _prompts.Count());  
        Console.WriteLine(_prompts[someRandomNumber]);
        Console.WriteLine("{0}", _prompts.ElementAt(someRandomNumber));
        Console.ReadKey();
    }
}

    /*public static void SaveToPrompts(List<string> prompts)
    {
        string filename = "prompts.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(string p in prompts)
            {
                outputFile.WriteLine(p);
            }
        }
    }
}
```

This code initializes the `_prompts` list with the five prompts that were previously commented out, and adds the "One" prompt to it. The `GeneratePrompt` method is left empty for now, as it's not clear what it should do. The `SaveToPrompts` method is also fixed to correctly write each prompt to the output file.*/