using System;
using BibliotekaStruct;
namespace PDF2
{
    internal class PDF2
    {
        static void Main()
        {
            //Задание 1
            Console.WriteLine("Задание 1");
            Console.WriteLine($@"sbyte – {sbyte.MaxValue} – {sbyte.MinValue}
byte – {byte.MaxValue} – {byte.MinValue}
short – {short.MaxValue} – {short.MinValue}
ushort – {ushort.MaxValue} – {ushort.MinValue}
int – {int.MaxValue} – {int.MinValue}
uint – {uint.MaxValue} – {uint.MinValue}
long – {long.MaxValue} – {long.MinValue}
ulong – {ulong.MaxValue} – {ulong.MinValue}
float – {float.MaxValue} – {float.MinValue}
double – {double.MaxValue} – {double.MinValue}
decimal – {decimal.MaxValue} – {decimal.MinValue}");

            //Задание 2
            Console.WriteLine("Задание 2");
            var name = ConsoleHelper.ReadString("Введите имя");
            var sity = ConsoleHelper.ReadString("Введите город");
            var age = ConsoleHelper.ReadInt("Введите возраст");
            var pin = ConsoleHelper.ReadInt("Введите  PIN-код");
            var polsovatel = new Polsovatel
            {
                Name = name,
                Sity = sity,
                Age = age,
                Pin = pin
            };
            ConsoleHelper.PrintPolsovatel(polsovatel);

            //Задание 3
            Console.WriteLine("Задание 3");
            var text = ConsoleHelper.ReadString("Введите текст");
            //Мы создаем массив с типом данных char (т.к. работаем с одиночными символами), в котором в квадратных скобках пишется, сколько памяти мы выделяем. text.Length - считает количество символов. 
            var chars = new char[text.Length];
            //Создаем цикл, который будет перебирать каждый символ до тех пор, пока количество символов больше, чем i. каждый раз после завершения действия он прибавляет к i единицу
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))  //Проверяет заглавная ли буква. в круглых скобках пишется номер символа. он определяется с помощью text[i]
                    chars[i] = char.ToLower(text[i]); //если да, то делает маленькой
                else
                    chars[i] = char.ToUpper(text[i]); //если нет, то делает заглавной
            }
            string result = new(chars); //Здесь мы берем массив и объединяем все его элементы в строку
            Console.WriteLine($"Результат: {result}");

            //Задание 4
            Console.WriteLine("Задание 4");
            var stroka = ConsoleHelper.ReadString("Введите строку");
            var sub = ConsoleHelper.ReadString("Введите подстроку");
            int count = 0; //Хранит итоговое количество вхождений
            int index = 0; //Позиция, с который будет проверка
            //Данный цикл работает, пока index!=-1
            while ((index = stroka.IndexOf(sub, index)) != -1) //stroka.IndexOf(sub, index) - Метод ищет подстроку sub в строке stroka, начиная с позиции index, если находит, то работает дальше, если нет, то возвращает -1 ()это заложено в методе
            {
                count++; //увеличиваем счетчик на 1
                index += sub.Length; //Здесь мы сдвигаем на длину найденной подстроки, чтобы он правильно считал
            }
            Console.WriteLine($"Количество вхождений: {count}");

            //Задание 5
            Console.WriteLine("Задание 5");
            var normPrice = ConsoleHelper.ReadPrice("Введите стоимость алкоголя без скидки");
            var salePrice = ConsoleHelper.ReadPrice("Введите размер скидки (в процентах)");
            var holidayPrice = ConsoleHelper.ReadPrice("Введите стоимость отпуска");
            Console.WriteLine($"Количество бутылок: {Math.Floor(holidayPrice / (normPrice * salePrice / 100))}");

            //Задание 6
            Console.WriteLine("Задание 6");
            //Создаем массив. Первые скобки означают, что у нас не одна переменная, а набор переменных типа AnketaAlkogol, а вторые - сколько у нас места
            AnketaAlkogol[] students = new AnketaAlkogol[5];
            // Студент 1
            students[0].LastName = "Иванов";
            students[0].FirstName = "Иван";
            students[0].Id = 10157;
            students[0].Birthday = new DateTime(2008, 1, 1); //DateTime - это структура, поэтому мы ее вызываем. Дата записывается только так, как в скобках.
            students[0].Category = Alkogol.a;
            students[0].Volume = 0.5;
            students[0].Drink = new Napitok { Name = "Водка", Prozent = 40 };

            // Студент 2
            students[1].LastName = "Петров";
            students[1].FirstName = "Петр";
            students[1].Id = 10158;
            students[1].Birthday = new DateTime(2008, 2, 2);
            students[1].Category = Alkogol.b;
            students[1].Volume = 1;
            students[1].Drink = new Napitok { Name = "Пиво", Prozent = 5 };

            // Студент 3
            students[2].LastName = "Сергеев";
            students[2].FirstName = "Сергей";
            students[2].Id = 10159;
            students[2].Birthday = new DateTime(2008, 3, 3);
            students[2].Category = Alkogol.c;
            students[2].Volume = 0.25;
            students[2].Drink = new Napitok { Name = "Вино", Prozent = 12 };

            // Студент 4
            students[3].LastName = "Морозова";
            students[3].FirstName = "Мария";
            students[3].Id = 10160;
            students[3].Birthday = new DateTime(2008, 4, 4);
            students[3].Category = Alkogol.d;
            students[3].Volume = 2;
            students[3].Drink = new Napitok { Name = "Сок", Prozent = 0 };

            // Студент 5
            students[4].LastName = "Цветкова";
            students[4].FirstName = "Света";
            students[4].Id = 10161;
            students[4].Birthday = new DateTime(2008, 5, 5);
            students[4].Category = Alkogol.a;
            students[4].Volume = 1.5;
            students[4].Drink = new Napitok { Name = "Егермейстер", Prozent = 40 };

            double AllValume = 0; //Считаем общий объем выпитой жидкости
            double AllPozent = 0; //Считаем количество выпитого алгоколя
            for (int i = 0; i < students.Length; i++) //Здась начинаем отсчет от 0 и пока i меньшк количества студентов, продолжаем цикл 
            {
                AllValume += students[i].Volume; //Прибавляем каждый раз объем жидкости студента под номером i
                AllPozent += students[i].Volume * students[i].Drink.Prozent / 100; //Также как сверху, но считает объем алкоголя
            }

            Console.WriteLine($"Общий объём жидкости: {AllValume} л");
            Console.WriteLine($"Общий объём алкоголя: {AllPozent} л");
            Console.WriteLine();

            for (int i = 0; i < students.Length; i++)
            {
                double volumePercent = students[i].Volume / AllValume * 100;
                double studentAlcohol = students[i].Volume * students[i].Drink.Prozent / 100;
                double alcoholPercent = studentAlcohol / AllPozent * 100;
                Console.WriteLine($"Студент {i + 1}:"); //Не забываем, что отсчет начинается с 0
                Console.WriteLine($"Фамилия: {students[i].LastName}");
                Console.WriteLine($"Имя: {students[i].FirstName}");
                Console.WriteLine($"ID: {students[i].Id}");
                Console.WriteLine($"Дата рождения: {students[i].Birthday:dd.MM.yyyy}"); //dd.MM.yyyy - это символы, означающие конкретные значения. Если мы напишем mm, то это будут минуты 
                Console.WriteLine($"Категория: {students[i].Category} — {ConsoleHelper.GetCategoryText(students[i].Category)}");
                Console.WriteLine($"Напиток: {students[i].Drink.Name} ({students[i].Drink.Prozent}%)");
                Console.WriteLine($"Объём: {students[i].Volume} л");
                Console.WriteLine($"Доля жидкости: {volumePercent:F1}%"); //:F1 — это формат: один знак после запятой.
                Console.WriteLine($"Доля алкоголя: {alcoholPercent:F1}%");
                Console.WriteLine();
            }
        }
    }
}
