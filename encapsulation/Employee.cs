using System;

public class Employee
{
	private string _username;
	private bool _password;
	
	public Employee(string Username, bool Password)
	{
		_username = Username;
		_password = Password;
	}
	public string setPassword(bool Password)
	{
		if (Password = "HELLO!")
		{
			Console.WriteLine($"Thank you coming. Have a lovely day!");
		}
		else
		{
			throw new Exception("Incorrect Password. Please enter the correct Password.");
		}
		Console.ReadKey();
	}
}
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Employee employee = new Employee();
           
            employee.SetPassword(input);
            Console.WriteLine(employee.getPassword());
            Password = Console.ReadLine();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }   
}