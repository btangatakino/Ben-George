using System;
using System.Text;

namespace Tutlane
{
   public class Laptop
   {
      private string brand;
      private string model;
      private string systemType;
      public string Brand
      {
         get { return brand; }
         set { brand = value; }
      }
      public string Model
      {
         get { return model; }
         set { model = value; }
      }
      public string SystemType
      {
        get { return systemType; }
        set { systemType = value; }
      }
      public void LaptopDetails()
      {
         Console.WriteLine("Brand: " + Brand);
         Console.WriteLine("Model: " + Model);
         Console.WriteLine("SystemType: " + SystemType);
      }
      public void LaptopKeyboard()
      {
         Console.WriteLine("Type using Keyword");
      }
      private void MotherBoardInfo()
      {
         Console.WriteLine("MotheBoard Information");
      }
      private void InternalProcessor()
      {
         Console.WriteLine("Processor Information");
      }
   }
   class Program
   {
      static void Main(string[] args)
      {
         Laptop l = new Laptop();
         l.Brand = "Dell";
         l.Model = "Inspiron 14R";
         l.SystemType = "x64-base PC";
         l.LaptopDetails();
         Console.WriteLine("\nPress Enter Key to Exit..");
         Console.ReadLine();
      }
   }
}