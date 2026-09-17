using System;
using System.Globalization; 
namespace BibliotekaStruct
{
    
    //Классная работа 

    //Задание 1
    public struct Candidat //Это структура, которую мы можем использовать, если подключим библиотеку
    {

        public string Name;
        public int Age;
        public double Height;
        public double Weight;
        public string FavoriteMovie;
    }
        //Можем внутри структур повторять названия переменных, т.к. они относятся только к этой структуре

        //Задание 2
    public enum VagonType
    {
        Platzkart,
        Coupe,
        SV,
        Lux
    }
    public struct Bilet
    {
        public string PassengerName;
        public string TrainNumber;
        public DateTime DepartureDate;
        public TimeSpan DepartureTime;
        public VagonType BiletType;
        public decimal TicketPrice;
    }

    //Задание 3

    public enum AutoClass
    {
        Economy,
        Comfort,
        Business,
        Premium
    }
    public struct AutoKlient
    {
        public string NameKlient;
        public string AutoMarka;
        public AutoClass AvtoClass;
        public DateTime ArendaData;
        public DateTime ArendaFinish;
        public decimal ArendaPrice;
    }

    //Задание 4

    public enum Facultets
    {
        IT,
        Economy,
        Law,
        Design
    }
    public struct Student
    {
        public string NameStudent;
        public int NumberStudent;
        public Facultets NameFacultet;
        public int CursStudent;
        public double BallStudent;
        public DateTime DateStudent;

    }

    //Лабораторная работа 2

    //Упражнение 3.1
    public enum Bank
    {
        BankAccount,
        SavinksAccount
    }

    //Упражнение 3.2
    public struct Bankovski
    {
        public int BankovskyAccount;
        public Bank AccountType;
        public decimal Balans;
    }

    //Домашнее задание 3.1
    public enum Vuz
    {
        KGU,
        KAI,
        KHTI

    }
    public struct Rabotnic
    {
        public string NameRabotnic;
        public Vuz VuzRabotnic;
    }

    //PDF2

    //Задание 2
    public struct Polsovatel
    {
        public string Name;
        public string Sity;
        public int Age;
        public int Pin;
    }

    //Задание 6
    public enum Alkogol
    {
        a, b, c, d
    }
    public struct Napitok
    {
        public string Name;
        public double Prozent;
    }
    public struct AnketaAlkogol
    {
        public string LastName;
        public string FirstName;
        public int Id;
        public DateTime Birthday;
        public Alkogol Category;
        public double Volume;
        public Napitok Drink;

    }


    public static class ConsoleHelper
    {
        //Классная работа 

        //Задание 1

        //Создаем метод, чтобы он проверял строку на наличие null, достаточно полезно, исключает исключения
        public static string ReadString(string prompt) //вот здесь мы указываем, что в скобках будет строка, которая помещается в prompt
        {
            while (true) //цикл будет повторятся, пока его не прервет return
            {
                Console.Write($"{prompt}: "); //здесь выводится текст, который мы введем в скобках при использовании метода. Т.к. Console.Write, то дальше текст будет вводится на той же строке
                var input = Console.ReadLine()?.Trim(); //? - если null, то код не падает, а выдает пустую строку. .Trim() - убирает пробелы в начале и конце строки
                if (!string.IsNullOrEmpty(input)) //Проверка на пустоту, если строка НЕ пустая, то цикл прекращается
                                                  //string.IsNullOrEmpty - метод, встроенный в библиотеку System
                    return input;
                Console.WriteLine("Ошибка: Поле не может быть пустым. Попробуйте снова.");

            }
        }
        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (целое число): "); //здесь мы дописали целое число, т.е. можем не писать это, нам надо написать только промпт и к нему добавится подсказка
                var input = Console.ReadLine(); //мы можем писать одинаковую переменную input в разных методах, потому что каждый метод как закрытая комната, и input существует только внутри нее

                if (int.TryParse(input, out var value)) //Проверяет введеное число, и если это не число или введено неправильно, то false и цикл начинается с начала, если TryParse возвращает true, то цикл прекращается и переменной присваивается значение value
                    return value;
                Console.WriteLine("Ошибка: Пожалуйста, введите корректное целое число.");
            }
        }
        public static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt}: ");
                var input = Console.ReadLine();

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out var value))
                    //NumberStyles.Any - принимает числа в любом формате(отрицательные, целые итд)
                    //CultureInfo.InvariantCulture - принимает числа с точной или запятой
                    return value;

                Console.WriteLine("Ошибка: Пожалуйста, введите число в формате 1.75");
            }
        }
        public static void PrintCandidates(Candidat app) //Здесь написано, что мы вводим текст типа Candidat, который сохраняется в переменную app
        {
            Console.WriteLine($"Имя кандидата: {app.Name}\nВозраст кандидата: {app.Age}\nРост кандидата: {app.Height}\nВес кандидата: {app.Weight}\nЛюбимый фильм кандидата: {app.FavoriteMovie}");
        }

        //Задание 2

        public static DateTime ReadData(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (например, 14.09.2026): ");
                var input = Console.ReadLine();
                if (DateTime.TryParse(input, out var value))
                    return value;
                Console.WriteLine("Ошибка: Введите дату в формате дд.мм.гггг (например, 14.09.2026)");
            }

        }
        public static TimeSpan ReadTime(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (например, 21:08): ");
                var input = Console.ReadLine();
                if (TimeSpan.TryParse(input, out var value))
                    return value;
                Console.WriteLine("Ошибка: Введите время в формате хх:хх (например, 21:08)");
            }
        }
        public static VagonType ReadType(string prompt) //Мы создали метод, который читает строку и превращает ее в тип перечисление
        {
            while (true)
            {
                Console.Write($"{prompt}:");
                var input = Console.ReadLine();
                if (Enum.TryParse(input, true, out VagonType value)) //true игнорирует, если слова написаны большими или маленькими буквами
                    return value;
                Console.WriteLine("Ошибка: Введите одно из значений: Platzkart, Coupe, SV, Lux");
            }
        }
        public static decimal ReadPrice(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (если число не целое, то введите так: 5600,00):");
                var input = Console.ReadLine();
                if (decimal.TryParse(input, CultureInfo.InvariantCulture, out var value))
                    return value;
                Console.WriteLine("Ошибка: введите дробное число (пример, 5600,0)");
            }
        }
        public static void PrintBilet(Bilet app)
        {
            Console.WriteLine($"ФИО: {app.PassengerName}\nНомер поезда: {app.TrainNumber}\nДата отправления: {app.DepartureDate}\nВремя отправления: {app.DepartureTime}\nТип вагона: {app.BiletType}\nЦена билета: {app.TicketPrice}");
        }

        //Задание 3

        public static AutoClass ReadClass(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (Economy, Comfort, Business, Premium):");
                var input = Console.ReadLine();
                if (Enum.TryParse(input, true, out AutoClass value))
                    return value;
                Console.Write("Ошибка: введите класс из списка (Economy, Comfort, Business, Premium)");
            }
        }
        public static void PrintAutoKlient(AutoKlient app)
        {
            Console.WriteLine($"Имя клиента: {app.NameKlient}\nМарка автомобиля: {app.AutoMarka}\nКласс автомобиля: {app.AvtoClass}\nНачало аренды: {app.ArendaData}\nОкончание аренды: {app.ArendaFinish}\nЦена аренды за сутки: {app.ArendaPrice}");
        }

        //Задание 4

        public static Facultets ReadFacultets(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (IT, Economy, Law, Design): ");
                var input = Console.ReadLine();
                if (Enum.TryParse(input, true, out Facultets value))
                    return value;
                Console.WriteLine("Ошибка: введите факультет из списка (IT, Economy, Law, Design)");
            }
        }
        public static void PrintAnketaStudenta(Student app)
        {
            Console.Write($"ФИО студента: {app.NameStudent}\nНомер зачетной книжки: {app.NumberStudent}\nФакультет: {app.NameFacultet}\nНомер курса: {app.CursStudent}\nСредний балл студента: {app.BallStudent}\nДата окончания учебы: {app.DateStudent}");
        }

        //Лабораторная работа 2

        //Упражнение 3.2
        public static Bank ReadBank(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (BankAccount, SavinksAccount): ");
                var input = Console.ReadLine();
                if (Enum.TryParse(input, true, out Bank value))
                    return value;
                Console.WriteLine("Ошибка: введите тип счета (BankAccount, SavinksAccount)");
            }
        }
        public static void PrintBank(Bankovski app)
        {
            Console.WriteLine($"Номер счета: {app.BankovskyAccount}\nТип счета: {app.AccountType}\nБаланс: {app.Balans}");
        }

        //Домашнее задание 3.1
        public static Vuz ReadVuz(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (KGU, KAI,  KHTI):");
                var input = Console.ReadLine();
                if (Enum.TryParse(input, true, out Vuz value))
                    return value;
                Console.WriteLine("Ошибка: введите тип счета (KGU, KAI,  KHTI)");
            }
        }
        public static void PrintRabotnic(Rabotnic app)
        {
            Console.WriteLine($"Имя работника: {app.NameRabotnic}\nВуз: {app.VuzRabotnic}");
        }

        //PDF2

        //Задание 2
        public static void PrintPolsovatel(Polsovatel app)
        {
            Console.WriteLine($"Имя пользователя: {app.Name}\nГород: {app.Sity}\nВозраст пользователя: {app.Age}\nПин-код {app.Pin}");
        }

        //Задание 6
        public static string GetCategoryText(Alkogol category)
        {
            return category switch
            {
                Alkogol.a => "алкоголик",
                Alkogol.b => "любитель выпить",
                Alkogol.c => "пьёт по праздникам",
                Alkogol.d => "не пьёт"
            };
        }
    }

}
