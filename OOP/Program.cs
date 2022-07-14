using OOP;
class Program
{
    static void Main()
    {
        BankAccount mybankaccount = new BankAccount();

        Console.WriteLine("Задание к уроку №2");
        Console.WriteLine("Номер счёта:");
        Console.WriteLine(mybankaccount.AccountNumber);
        Console.WriteLine("Доступный баланс:");
        Console.WriteLine(mybankaccount.Balance);
        Console.WriteLine("Тип счёта:");
        Console.WriteLine(mybankaccount.Savings);
        Console.WriteLine("Завершение программы");
        Console.ReadLine();
    }
}