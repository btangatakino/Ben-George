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
        new List<string>{ "Moses 1 39", "For behold this is my work and my glory-to bring to pass the immortality and eternal life of man." },
        new List<string>{ "James 3 5 6", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed." },
        new List<string>{ "Proverbs 3 5 6", "Trust in the Lord with all your heart; and lean not unto thine own understanding. In all thy ways, aknowledge him, and he shall direct thy paths." },
        new List<string>{ "1 Nephi 3 7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them." }
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
        
        string[] data = scriptList[index][0].Split();
        string text = scriptList[index][1];
        if(data.Length == 3)
        {
            scripture = new Scriptures(data[0], int.Parse(data[1]), int.Parse(data[2]), text);
        }
        else{
            scripture = new Scriptures(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), text);
        }
        return scripture;
    }
}