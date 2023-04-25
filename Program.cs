using Practice___Virtual__Overriding__and_New;
class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            SavingsAccount savings = new SavingsAccount("John Doe", 1000, 0.05);
            CheckingAccount checking = new CheckingAccount("Jane Smith", 500, 25);
            RetriementAccount retirement = new RetriementAccount("Bob Johnson", 2000, 0.1);

        
            accounts.Add(savings);
            accounts.Add(checking);
            accounts.Add(retirement);
            foreach (BankAccount account in accounts)
            {
            account.Deposit(500);
            account.Deposit(-50000);
            account.Withdraw(200);
            account.Withdraw(-200000);
            account.Withdraw(account.Balance + 1);
            Console.WriteLine(account.ToString());

            
            }
        }
    }
