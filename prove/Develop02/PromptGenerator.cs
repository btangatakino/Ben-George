using System;
using System.Collections.Generic;

public class PromptGenerator
{
    List<String> _prompts = new List<String>();

    _prompts.Add("What is one memorable thing that happened today");
    _prompts.Add("What is one memorable thing that happened today");

    foreach(String item in _prompts)
    {
        Console.WriteLine(item);
    }
    Console.ReadKey();
}