namespace Luffy
{
    public class BankAccount
    {
        private int balance { get; set; }

        public BankAccount()
        {
            balance = 0;
        }
        public bool Deposit(int amount)
        {
            balance += amount;
            return true;
        }

        public bool Withdraw(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
        public int GetBalance()
        {
            return balance;
        }


    }

  
}
