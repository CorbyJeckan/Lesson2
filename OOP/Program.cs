using OOP;
class Program
{
    static void Main()
    {
        BankAccount mybankaccount = new BankAccount("Сберегательный счёт", "Кредитный счёт", 15200, 17950, 15674894, 15674895); ;

        Console.WriteLine("Задание к уроку №2");
        Console.WriteLine("Номер счёта:");
        Console.WriteLine(mybankaccount.AccountNumber);
        Console.WriteLine("Доступный баланс:");
        Console.WriteLine(mybankaccount.Balance);
        Console.WriteLine("Тип счёта:");
        Console.WriteLine(mybankaccount.Savings);
        Console.WriteLine("Номер счёта:");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(mybankaccount.AccountNumber2);
        Console.WriteLine("Доступный баланс:");
        Console.WriteLine(mybankaccount.Balance2);
        Console.WriteLine("Тип счёта:");
        Console.WriteLine(mybankaccount.Credit);
        Console.WriteLine("Введите номер счёта");
        Console.ReadLine();
        Console.WriteLine("Завершение программы");
        
    }
}