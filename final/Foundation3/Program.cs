using System;

class Program
{
    static void Main(string[] args)
    {
        //Lectures lecture = new Lectures();/*("Web Fundamentals", "Fundamentals in Web Design", "23rd October 2023", "10:00 am", "24 Symmonds Street", "Doctor Simmons", 300);*/

        Address address = new Address();

        Lectures lecture = new Lectures("Web Fundamentals", "Fundamentals in Web Design", "23rd October 2023", "10:00 am", "Mangere Auckland New Zealand", "Doctor Simmons", 300, "This is the last lecture of the year on this topic", "Lecture");

        /*lecture.SetEventTitle("Web Fundamentals");
        lecture.SetDescription("Fundamental in Web Design");
        lecture.SetDate("23rd October 2023");
        lecture.SetTime("10:00 am");
        lecture.SetAddress("24 Symmonds Street");
        lecture.SetLecturer("Doctor Simmons");
        lecture.SetCapacity(300);
        lecture.SetEventInfo("This is the last lecture of the year on this topic");
        lecture.SetEventType("Lecture");*/

        lecture.StandardDetails();
        Console.WriteLine();
        lecture.FullDetails();
        lecture.DisplayInfor();
        Console.WriteLine();
        lecture.ShortDescription();
        
    }
}