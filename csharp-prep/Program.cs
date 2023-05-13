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
        Cars car1 = new Cars();
        car1._brand = "Toyota";
        car1._color = "Blue";
        car1._drive = "4 Wheeler";

        Cars car2 = new Cars();
        car2._brand = "Honda";
        car2._color = "Red";
        car2._drive = "2 Wheel Drive";

        List<Cars> car = new List<Cars>();
        car.Add(car1);
        car.Add(car2);

        foreach (Cars c in car)
        {
            Console.WriteLine($"{c._brand} {c._color} {c._drive}");
        }

        SaveToFile(car);
    }

    public static void SaveToFile(List<Cars> car)
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