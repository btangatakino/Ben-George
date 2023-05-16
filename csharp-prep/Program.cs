using System;
using System.Collections.Generic;
using System.IO;

public class Cars
{
    public string _color;
    public string _drive;
    public string _brand;

    public void CarInfo()
    {
        Console.WriteLine($"{_color} {_drive} {_brand}");
    }
}    
class Program
{
    static void Main(string[] args)
    {
        //new Cars object created named car1
        Cars car1 = new Cars();
        //setting variables to the new Cars object, car1
        car1._brand = "Toyota";
        car1._color = "Blue";
        car1._drive = "4 Wheeler";

        //new Cars object created named car2
        Cars car2 = new Cars();
        //setting variables to the new Cars object, car2
        car2._brand = "Honda";
        car2._color = "Red";
        car2._drive = "2 Wheel Drive";

        //create a List of Cars object and name it car
        List<Cars> car = new List<Cars>();
        //car1 and car2 added to the list car
        car.Add(car1);
        car.Add(car2);

        //for each object in the list c in car, their brand, color, and drive is displayd
        foreach (Cars c in car)
        {
            Console.WriteLine($"{c._brand} {c._color} {c._drive}");
        }

        //SaveToFile is called using the list car as the variablle
        static void SaveToFile(List<Cars> car)
        {
        string fileName = "car.text";

        using (StreamWriter ouputFile = new StreamWriter(fileName))
        {
            foreach (Cars c in car)
            {
                ouputFile.WriteLine($"{c._brand} {c._color} {c._drive}");
            }
        }
        }
    }
}