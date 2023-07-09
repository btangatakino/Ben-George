using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // creating new Video instances
        Video video1 = new Video();
        video1._title = "You are the reason";
        video1._author = "Calum Scott";
        video1._lengthInSeconds = 204;

        /*Video video2 = new Video("", "", 10);
        Video video3 = new Video("", "", 10);*/

        // creating new Comment instances
        Comment v1Comment1 = new Comment();
        v1Comment1._nameOfPerson = "Jeferson Zucoloto";
        v1Comment1._comment = "Such a beautiful song. I've just got home, I was in London last December. This song makes me remember everything I felt there.";

        Comment v1Comment2 = new Comment();
        v1Comment2._nameOfPerson = "Fabricio Meneses";
        v1Comment2._comment = "Can't get enough of this song. Love it so much.";

        Comment v1Comment3 = new Comment();
        v1Comment3._nameOfPerson = "Tiara Kohlisch";
        v1Comment3._comment = "It's not only the melody and the lyrics which brought me to tears, this music video is a masterpiece too.";

        video1._comments.Add(v1Comment1);
        video1._comments.Add(v1Comment2);
        video1._comments.Add(v1Comment3);

        video1.Display();
    }
}