namespace OOP
{
    public class BankAccount
    {
        private int _AccountNumber = 15674894;
        private double _Balance = 15200;
        private string _Savings = "Сберегательный счёт";

        
        public int AccountNumber
        {
            get
            {
                return Random.Shared.Next();
            }
            set
            {
                _AccountNumber = value;
            }
        }
        public double Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                _Balance = value;
            }
        }
            public string Savings
        {
            get
            {
                return _Savings;
            }
            set
            {
                _Savings = value;
            }
        }


        //public BankAccount() //Конструктор по умолчанию
        //{
        //    _AccountNumber = Random.Shared.Next();
        //    _Balance = 15200;
        //    _Savings = "Сберегательный счёт";
        //}

    public BankAccount(string savings, double balance, int accountNumber)//Конструктор с параметрами
        {
            _Savings = savings;
            _Balance = balance;
            _AccountNumber = accountNumber;
        }
    }

    
}
