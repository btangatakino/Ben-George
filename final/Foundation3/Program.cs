using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("Web Fundamentals", "Fundamentals in Web Design", "23rd October 2023", "10:00 am", "Mangere Auckland New Zealand", "Doctor Simmons", 300, "This is the last lecture of the year on this topic", "Lecture");

        lecture.StandardDetails();
        Console.WriteLine();
        lecture.FullDetails();
        lecture.DisplayInfor();
        Console.WriteLine();
        lecture.ShortDescription();

        Receptions reception = new Receptions("Microsoft 365", "How to use Microsoft 365 programs", "21st August 2023", "5:00 pm", "34 Mount St Auckland New Zealand", "Receptions", "Programs will be Word, Excel, Powerpoint and Access", "reception007@home.com");

        reception.StandardDetails();
        Console.WriteLine();
        reception.FullDetails();
        reception.DisplayInfor();
        Console.WriteLine();
        reception.ShortDescription();

        OutdoorGatherings outdoorG = new OutdoorGatherings("Wedding", "Tom and Heidi's Wedding", "18th December 2023", "2:00 pm", "115 Hall Avenue, Mangere, Auckland, New Zealand", "Wedding", "Wedding of the Century", "Beautiful Sunny Day");

        outdoorG.StandardDetails();
        Console.WriteLine();
        outdoorG.FullDetails();
        outdoorG.DisplayInfor();
        Console.WriteLine();
        outdoorG.ShortDescription();        
    }
}