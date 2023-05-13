using System;

public class Employee
{
    private int _id;
    private string _firstName;
    private string _lastName;
    private string _position;
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    public string Position
    {
        get { return _position; }
        set { _position = value; }
    }
    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }
    public void StaffInformation()
    {
        Console.WriteLine("First Name: " + FirstName);
        Console.WriteLine("Last Name: " + LastName);
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Position: " + Position);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee E = new Employee();
        E.FirstName = "John";
        E.LastName = "Doe";
        E.ID = 007;
        E.Position = "IT Manager";
        E.StaffInformation();
        Console.WriteLine("\nPress Enter Key to Exit..");
        Console.ReadLine();
    }
}