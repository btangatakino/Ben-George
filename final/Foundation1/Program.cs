using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nProgram1 - YouTube");

        // creating new Video instances
        Video video1 = new Video();
        video1._title = "You are the reason";
        video1._author = "Calum Scott";
        video1._lengthInSeconds = 204;

        Video video2 = new Video();
        video2._title = "Fakateretere";
        video2._author = "Gabilou";
        video2._lengthInSeconds = 219;

        Video video3 = new Video();
        video3._title = "Arizona Zervas";
        video3._author = "Roxanne";
        video3._lengthInSeconds = 160;

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

        Comment v2Comment1 = new Comment();
        v2Comment1._nameOfPerson = "Lourdes Yanez";
        v2Comment1._comment = "Wonderful!! Gorgeous song!! Beautiful arrangements!! Great!! Greetings from Mexico!!";

        Comment v2Comment2 = new Comment();
        v2Comment2._nameOfPerson = "Muale Oarani";
        v2Comment2._comment = "Amazing voice thank you.";

        Comment v2Comment3 = new Comment();
        v2Comment3._nameOfPerson = "Like Thompson";
        v2Comment3._comment = "This is one of my favorite songs. I used to be a Polynesian dancer. My granddaughter loves this song also.";

        Comment v3Comment1 = new Comment();
        v3Comment1._nameOfPerson = "Nolongerinuse";
        v3Comment1._comment = "This song has so many memories attached to it for me.";

        Comment v3Comment2 = new Comment();
        v3Comment2._nameOfPerson = "Robloxpoeple4304";
        v3Comment2._comment = "LOVE THIS SONG! !!!lost for words for how good this song is am I right";

        Comment v3Comment3 = new Comment();
        v3Comment3._nameOfPerson = "AltJGirl";
        v3Comment3._comment = "One of my friends sang this in class before he passed away. I reminds me of him.";

        video1._comments.Add(v1Comment1);
        video1._comments.Add(v1Comment2);
        video1._comments.Add(v1Comment3);

        video2._comments.Add(v2Comment1);
        video2._comments.Add(v2Comment2);
        video2._comments.Add(v2Comment3);

        video3._comments.Add(v3Comment1);
        video3._comments.Add(v3Comment2);
        video3._comments.Add(v3Comment3);

        video1.Display();
        video2.Display();
        video3.Display();
    }
}