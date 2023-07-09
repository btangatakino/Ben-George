using System;

class Program
{
    static void Main(string[] args)
    {
        // creating new Video instances
        Video video1 = new Video("You are the reason", "Calum Scott", 204);
        Video video2 = new Video("", "", 10);
        Video video3 = new Video("", "", 10);

        // creating new Comment instances
        Comment v1Comment1 = new Comment("Jeferson Zucoloto", "Such a beautiful song. I've just got home, I was in London last December. This song makes me remember everything I felt there.");
        Comment v1Comment2 = new Comment("Fabricio Meneses", "Can't get enough of this song. Love it so much.");
        Comment v1Comment3 = new Comment("Tiara Kohlisch", "It's not only the melody and the lyrics which brought me to tears,  this music video is a masterpiece too.");
    }
}