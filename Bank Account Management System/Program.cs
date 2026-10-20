namespace Bank_Account_Management_System
{
    class BankAccount
    {
        public int AccountNumber;
        public string OwnerName;
        public double Balance;
        public BankAccount(int AccountNumber, string OwnerName, double Balance)
        {
            this .AccountNumber = AccountNumber;
            this. OwnerName= OwnerName;
            this.Balance = Balance;
        }
        public double Deposit(double amount)
        {
            if(amount >0)
            {
                Balance += amount;
            } else
                Console.WriteLine("Invalid operattor");

            return Balance;
        }
        public double WithDraw(double amount)
        {
            if(amount > Balance||amount <= 0)
            {
                Console.WriteLine("Invalid operattor");
            } else
            Balance-=amount ;
            return Balance;
        }
        public void ChangeOwner(string newName)
        {
             OwnerName = newName;
            
        }
        public void PrintDetails()
        {
            Console.WriteLine(AccountNumber);
            Console.WriteLine(OwnerName);
            Console.WriteLine(Balance);
            Console.WriteLine("===================");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(1001, "Ahmed", 5000);
            BankAccount account2 = new BankAccount(1002, "Omar", 3000);
            
            account1.PrintDetails();
            account2.PrintDetails();
            account1.Deposit(1500);
            account2.WithDraw(2000);
            account1.WithDraw(10000);
            account1.ChangeOwner("Mohamed");
            account1.PrintDetails();
            Console.WriteLine("                         ");
            account2.PrintDetails();

        }
    }
}
