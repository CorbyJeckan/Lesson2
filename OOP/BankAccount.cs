namespace OOP
{
    public class BankAccount
    {
        private int _AccountNumber2 = 15674895;
        private int _AccountNumber = 15674894;
        private double _Balance = 15200;
        private double _Balance2 = 17950;
        private string _Savings = "Сберегательный счёт";
        private string _Credit = "Кредитный счёт";


        public int AccountNumber
        {
            get
            {
                return 15674894;
            }
            set
            {
                _AccountNumber = value;
            }
        }
        public int AccountNumber2
        {
            get
            {
                return 15674895;
            }
            set
            {
                _AccountNumber2 = value;
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
        public double Balance2
        {
            get
            {
                return _Balance2;
            }
            set
            {
                _Balance2 = value;
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
        public string Credit
        {
            get
            {
                return _Credit;
            }
            set
            {
                _Credit = value;
            }
        }


        //public BankAccount() //Конструктор по умолчанию
        //{
        //    _AccountNumber = Random.Shared.Next();
        //    _Balance = 15200;
        //    _Savings = "Сберегательный счёт";
        //}

        public BankAccount(string savings, string credit, double balance, double balance2, int accountNumber ,int accountNumber2)//Конструктор с параметрами
        {
            _Savings = savings;
            _Credit = credit;
            _Balance = balance;
            _Balance2 = balance2;
            _AccountNumber = accountNumber;
            _AccountNumber2 = accountNumber2;
        }
    }

    
}
