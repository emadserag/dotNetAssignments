class BankAccount
{
    private Dictionary<int, double> balances = new Dictionary<int, double>();
    private string accountNumber;
    public string AccountNumber
    {
        get { return accountNumber; }
        private set { accountNumber = value; }
    }
    public double Balance
    {
        get
        {
            return this[0]; 
        }
        private set
        {
            this[0] = value; 
        }
    }

    public BankAccount(string accNumber, double initialBalance = 0)
    {
        AccountNumber = accNumber;
        
        this.Balance = initialBalance;
    }
    public double this[int index]
    {
        get
        {
            return balances.GetValueOrDefault(index, 0);
        }
        set
        {
          
            balances[index] = value;
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposit successful. Amount: {amount:C}. New Balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit failed: Amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && HasSufficientFunds(amount))
        {
        
            Balance -= amount;
            Console.WriteLine($"Withdrawal successful. Amount: {amount:C}. New Balance: {Balance:C}");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Withdrawal failed: Amount must be positive.");
        }
        else
        {
            Console.WriteLine("Withdrawal failed: Insufficient funds.");
        }
    }

    public bool HasSufficientFunds(double amount)
    {
        return Balance >= amount;
    }

    public void TransferTo(BankAccount target, double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Transfer failed: Amount must be positive.");
            return;
        }

        if (HasSufficientFunds(amount))
        {
        
            Balance -= amount;
            target.Balance += amount;

            Console.WriteLine($"Transfer successful: {amount:C} transferred from {AccountNumber} to {target.AccountNumber}.");
            DisplayAccount();
            target.DisplayAccount();
        }
        else
        {
            Console.WriteLine($"Transfer failed: Account {AccountNumber} has insufficient funds.");
        }
    }

    public void DisplayAccount()
    {
        Console.WriteLine($"--- Account Details: {AccountNumber} ---");
        Console.WriteLine($"Main Balance (Index 0): {Balance:C}");

        if (balances.Count > 1)
        {
            Console.WriteLine("Other Currency Balances:");
            foreach (var kvp in balances)
            {
                if (kvp.Key != 0)
                {
                    Console.WriteLine($"  Index [{kvp.Key}]: {kvp.Value:N2}");
                }
            }
        }
    }
}
