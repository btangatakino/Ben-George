/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class PromptGenerator
{
    List<string> _promptsList = new List<string>()
    {
        "What is one memorable thing that happened today?",
        "Share an experience of Service today.",
        "Did you speak kind words to someone today?",
        "How have you seen the Lord's hand in your life today?",
        "Name an interesting person you met today and how?"
    };

    Random ran = new Random();

    public void GeneratePrompt()
    {
        int myIndex = ran.Next(_promptsList.Count);
         
        Console.WriteLine(_promptsList[myIndex]);
        Console.WriteLine("{0}", _promptsList.ElementAt(myIndex));
        Console.ReadKey();
    }
}