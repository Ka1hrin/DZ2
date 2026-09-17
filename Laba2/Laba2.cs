using System;
using BibliotekaStruct;
namespace Laba2
{
    internal class Laba2
    {
        static void Main()
        {
            //Упражнение 3.1
            Console.WriteLine("Упражнение 3.1");
            Bank bank = Bank.BankAccount; //Здесь мы присваиваем переменной значение одного из перечислений и печатаем
            Console.WriteLine($"Тип счета: {bank}");

            //Упражнение 3.2
            Console.WriteLine("Упражнение 3.2");
            var bankovskyAccount = ConsoleHelper.ReadInt("Введите номер банковского счета");
            var accountType = ConsoleHelper.ReadBank("Введите тип счета");
            var balans = ConsoleHelper.ReadPrice("Введите баланс счета");
            var account = new Bankovski
            {
                BankovskyAccount = bankovskyAccount,
                AccountType = accountType,
                Balans = balans
            };
            ConsoleHelper.PrintBank(account);

            //Домашнее задание 3.1
            Console.WriteLine("Домашнее задание 3.1");
            var nameRabotnic = ConsoleHelper.ReadString("Введите ФИО");
            Vuz vuzRabotnic = ConsoleHelper.ReadVuz("Введите название вуза");
            var rabAnketa = new Rabotnic
            {
                NameRabotnic = nameRabotnic,
                VuzRabotnic = vuzRabotnic
            };
            ConsoleHelper.PrintRabotnic(rabAnketa);

        }
    }
}

