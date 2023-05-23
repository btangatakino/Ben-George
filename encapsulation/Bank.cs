using System;

namespace EncapsulationDemo
{
    public class Bank
    {
        private int Amount;
        public int GetAmount()
        {
            return Amount;
        }
        public void SetAmount(int Amount)
        {
            if (Amount > 0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("Please Pass a Positive Value");
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            try
            {
                Bank bank = new Bank();
                //cannot access the Amount Variable directly
                //bank.Amount = -50; --> Complie Time Error
                bank.SetAmount(10);
                Console.ReadKey();
                Console.WriteLine(bank.GetAmount());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }   
    }
}