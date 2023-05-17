using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class PromptGenerator
{
    public string _displayPrompt;
    public void RandomPrompt()
    {
        List<string> promptsList = new List<string>();
        promptsList.Add("What is one memorable thing that happened today?");
        promptsList.Add("Share an experience of Service today.");
        promptsList.Add("Did you speak kind words to someone today?");
        promptsList.Add("How have you seen the Lord's hand in your life today?");
        promptsList.Add("Name an interesting person you met today and how?");

        Random random = new Random();
        int myIndex = random.Next(promptsList.Count);
        _displayPrompt = promptsList[myIndex];
        Console.WriteLine(_displayPrompt);
    }
}