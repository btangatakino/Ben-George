using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

internal class NewBaseType
{
    static void Main(string[] args)
    {
}

class Program : NewBaseType
{
    public class Scriptures
        {
            private List<Word> _script = new List<Word>();
            private string _scriptList;
            private string _reference;
            private string _text;
            
            public Scriptures(string text)
            {

            }
        }
        public class Word
        {
            private string _word;
            private bool _isHidden;

            public Word(string word)
            {
                _word = word;
                _isHidden = false;
            }
            public string GetWord()
            {
                Console.WriteLine("You have called the DisplayText method of the Scripture class");
                _text = text;
                text = "T am going to the shop tomorrow.";
                string[] words = text.Split(' ');
                foreach (String word in words)
                {
                    Word w = new Word(word);
                    _script.Add(w);
                    Console.WriteLine(word);
                }
            }
        }
    }
}