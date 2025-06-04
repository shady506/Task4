namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            var savAccounts = new List<Account>();
            savAccounts.Add(new SavingAccount());
            savAccounts.Add(new SavingAccount("Superman"));
            savAccounts.Add(new SavingAccount("Batman", 2000));
            savAccounts.Add(new SavingAccount("Wonderwoman", 5000, 5.0));

            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            // Checking
            var checAccounts = new List<Account>();
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            // Trust
            var trustAccounts = new List<Account>();
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);

            Console.WriteLine();
        }
        public static class AccountUtil
        {
            // Utility helper functions for Account class
            public static void Deposit(List<Account> accounts, double amount)
            {
                Console.WriteLine("\n=== Depositing to Accounts =================================");
                foreach (var acc in accounts)
                {
                    if (acc.Deposit(amount))
                        Console.WriteLine($"Deposited {amount} to {acc.Name}");
                    else
                        Console.WriteLine($"Failed Deposit of {amount} to {acc.Name}");
                }
            }

            public static void Withdraw(List<Account> accounts, double amount)
            {
                Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
                foreach (var acc in accounts)
                {
                    if (acc.Withdraw(amount))
                        Console.WriteLine($"Withdrew {amount} from {acc.Name}");
                    else
                        Console.WriteLine($"Failed Withdrawal of {amount} from {acc.Name}");
                }
            }

            // Helper functions for SavingsAccount
            //    public static void DepositSavings(List<SavingAccount> accounts, double amount)
            //    {
            //        Console.WriteLine("\n=== Depositing to Savings Accounts =================================");
            //        foreach (var acc in accounts)
            //        {
            //            if (acc.Deposit(amount))
            //                Console.WriteLine($"Deposited {amount} to {acc}");
            //            else
            //                Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            //        }
            //    }

            //    public static void WithdrawSavings(List<SavingAccount> accounts, double amount)
            //    {
            //        Console.WriteLine("\n=== Withdrawing from Savings Accounts ==============================");
            //        foreach (var acc in accounts)
            //        {
            //            if (acc.Withdraw(amount))
            //                Console.WriteLine($"Withdrew {amount} from {acc}");
            //            else
            //                Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            //        }
            //    }

            //    // Helper functions for CheckingAccount
            //    public static void DepositChecking(List<CheckingAccount> accounts, double amount)
            //    {
            //        Console.WriteLine("\n=== Depositing to Checking Accounts =================================");
            //        foreach (var acc in accounts)
            //        {
            //            if (acc.Deposit(amount))
            //                Console.WriteLine($"Deposited {amount} to {acc}");
            //            else
            //                Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            //        }
            //    }

            //    public static void WithdrawChecking(List<CheckingAccount> accounts, double amount)
            //    {
            //        Console.WriteLine("\n=== Withdrawing from Checking Accounts ==============================");
            //        foreach (var acc in accounts)
            //        {
            //            if (acc.Withdraw(amount))
            //                Console.WriteLine($"Withdrew {amount} from {acc}");
            //            else
            //                Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            //        }
            //    }

            //    // Helper functions for TrustAccount
            //    public static void DepositTrust(List<TrustAccount> accounts, double amount)
            //    {
            //        Console.WriteLine("\n=== Depositing to Trust Accounts =================================");
            //        foreach (var acc in accounts)
            //        {
            //            if (acc.Deposit(amount))
            //                Console.WriteLine($"Deposited {amount} to {acc}");
            //            else
            //                Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            //        }
            //    }

            //    public static void WithdrawTrust(List<TrustAccount> accounts, double amount)
            //    {
            //        Console.WriteLine("\n=== Withdrawing from Trust Accounts ==============================");
            //        foreach (var acc in accounts)
            //        {
            //            if (acc.Withdraw(amount))
            //                Console.WriteLine($"Withdrew {amount} from {acc}");
            //            else
            //                Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            //        }
            //    }
            //}
        }
    }

   
}

