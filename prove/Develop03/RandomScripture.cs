using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RandomScripture
{
    private Random random = new Random();
    // List to keep track of the used indexes
    public List<int> usedIndex = new List<int>();
    private List<List<string>> scriptList = new List<List<string>>()
    {
        new List<string>{ "Moses", "1", "39", null, "For behold this is my work and my glory-to bring to pass the immortality and eternal life of man." },
        new List<string>{ "James", "3", "5", "6", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed." },
        new List<string>{ "Proverbs", "3", "5", "6", "Trust in the Lord with all your heart; and lean not unto thine own understanding. In all thy ways, aknowledge him, and he shall direct thy paths." },
        new List<string>{ "Moroni", "10", "4", "5", "And when ye shall recieve these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things." },
        
        new List<string>{ "1 Nephi", "3", "7", null, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them." }
    };
    public Scriptures GenerateScripture()
    {
        Scriptures scripture;
        int index;
        do
        {
            index = random.Next(scriptList.Count);
        }
        while(usedIndex.Contains(index));
        usedIndex.Add(index);
        if(usedIndex.Count == scriptList.Count)
        {
            usedIndex.Clear();
        }
        List<string> rndScript =  scriptList[index];
        string book = rndScript[0];
        string chapter = rndScript[1];
        string start = rndScript[2];
        string end = rndScript[3];
        string text =rndScript[4];
        if(end == null)
        {
            scripture = new Scriptures(book, int.Parse(chapter), int.Parse(start), text);//this is a working line
        }
        else
        {
            scripture = new Scriptures(book, int.Parse(chapter), int.Parse(start), int.Parse(end), text);//this is a new line
        }/*case where you have a book number like 1 Nephi 3:7
        else
        {
            scripture = new Scriptures(int.Parse(data[0]), data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), text);
        }*/
        return scripture;
    }
}