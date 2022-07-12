namespace OOP
{
    internal class BankAccount
    {
        private int accountNumber = 15674894;
        private int balance = 15200;
        private string savings = "Сберегательный счёт";

        public string Savings { get { return savings; } set { savings = value; } }
        public int Balance { get { return balance; } set { balance = value; } }
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                AccountNumber = value;
            }
        }
    }
    
}
