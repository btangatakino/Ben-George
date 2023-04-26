using System;

public class Resume
{
    public string _name;
    //initialize list to a new list
    public List<Job> _jobs = new List<Job>();
   
    public void DisplayJobDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        } 
    }
}