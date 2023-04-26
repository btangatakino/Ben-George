using System;

class Program
{
    static void Main(string[] args)
    {
        // new Job instance named job1
        Job job1 = new Job();

        // setting member variables to job1
        job1._jobTitle = "Sofware Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //create another Job instance named job2
        Job job2 = new Job();

        //set member variable to job2
        job2._jobTitle = "Manager";
        job1._company = "Apple";
        job1._startYear = 2022;
        job1._endYear = 2023;

        //create new Resume instance named myResume
        Resume myResume = new Resume();


        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //myResume.DisplayJobDetails();

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
    }
}