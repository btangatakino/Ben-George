using System;
using System.Collections.Generic;

public class AaronicPriesthood
{
    protected string _name;
    protected string _office;
    public AaronicPriesthood()
    {
        _name = "Unknown";
        _office = "Unknown";
    }
    public AaronicPriesthood(string name, string office)
    {
        _name = name;
        _office = office;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetOffice()
    {
        return _office;
    }
    public void SetOffice(string office)
    {
        _office = office;
    }
    public string GetInfo()
    {
        return $"{_name} - {_office}";
    }
}
public class Priest : AaronicPriesthood
{
    public Priest() : base()
    {}
    public Priest(string name, string office) : base(name, office)
    {}
    public string Responsibilites()
    {
        return $"A {_office} can bless the Sacrament. A {_office} can baptize.";
    }
}
public class Teacher : AaronicPriesthood
{
    public Teacher() : base()
    {}
    public Teacher(string name, string office) : base(name, office)
    {}
    public string Responsibilites()
    {
        return $"A {_office} can prepare the Sacrament.";
    }
}
public class Deacon : AaronicPriesthood
{
    public Deacon() : base()
    {}
    public Deacon(string name, string office) : base(name, office)
    {}
    public string Responsibilites()
    {
        return $"A {_office} can pass the Sacrament.";
    }
}
static class Program
{
    static void Main(string[] args)
    {        
        AaronicPriesthood ap = new AaronicPriesthood();
        ap.SetName("James Wood");
        ap.SetOffice("Priest");
        Console.WriteLine(ap.GetInfo());

        Priest priest = new Priest();
        priest.SetName("Kevin Cook");
        priest.SetOffice("Priest");
        Console.WriteLine(priest.GetInfo());
        Console.WriteLine(priest.Responsibilites());

        Console.WriteLine();
        Teacher teacher = new Teacher();
        teacher.SetName("Dylan George");
        teacher.SetOffice("Teacher");
        Console.WriteLine(teacher.GetInfo());
        Console.WriteLine(teacher.Responsibilites());

        Console.WriteLine();
        Deacon deacon = new Deacon();
        deacon.SetName("Josh Daniel");
        deacon.SetOffice("Deacon");
        Console.WriteLine(deacon.GetInfo());
        Console.WriteLine(deacon.Responsibilites());
    }
}