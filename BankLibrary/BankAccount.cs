namespace BankLibrary
{
    public class BankAccount
    {
        public BankAccount(string accountNumber, float initialBalance)
        {
            Balance = initialBalance;
        }

        public float Balance { get; set; }

        public void Deposit(float amount)
        {
            Balance += amount;
        }
    }
}