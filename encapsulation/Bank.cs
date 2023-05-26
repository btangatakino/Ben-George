using System;

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
        public static void Main(string[] args)
        {
            try
            {
                Bank bank = new Bank();
                //cannot access the Amount Variable directly
                //bank.Amount = 50;// --> 'Bank.Amount' is  inaccessble due to its protection level
                
                //setting Positive Value
                bank.SetAmount(10);
                Console.WriteLine(bank.GetAmount());

                //setting Negative Value
                bank.SetAmount(-10);
                Console.WriteLine(bank.GetAmount());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }   
    }