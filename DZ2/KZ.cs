using System;
using BibliotekaStruct;
namespace DZ2
{
    internal class KZ
    {
        static void Main()
        {
            //Задание 0
            Console.WriteLine("Задание 0");
            byte oxygenLevel = 250;
            byte extraOxygen = 10;
            byte result = (byte)(oxygenLevel + extraOxygen); //т.к. мы явно пытаемся 260 засунуть в byte, то он берет остаток от деления числа на 256
            Console.WriteLine($"oxygenLevel - {oxygenLevel}\nextraOxygen - {extraOxygen}\nresult - {result}");
            Console.WriteLine((int)(oxygenLevel + extraOxygen));
            Console.WriteLine();

            //Задание 1
            Console.WriteLine("Задание 1");
            Console.WriteLine("===== Анкета космонавта =====");
            var name = ConsoleHelper.ReadString("Введите имя"); //Здесь мы используем класс ConsoleHelper, в нем несколько методов, поэтому мы подключаем ReadInt.
            var age = ConsoleHelper.ReadInt("Введите возраст кандидата");
            var height = ConsoleHelper.ReadDouble("Введите рост кандидата (в метрах, пример - 1.7)");
            var weight = ConsoleHelper.ReadDouble("Введите вес кандидата (в кг, пример - 52.5)");
            var favoriteMovie = ConsoleHelper.ReadString("Введите любимый фильм");
            //инициализатор объекта 
            //Создаём новую переменную candidate типа Candidat. Через new выделяем память под структуру.

            var candidate = new Candidat
            {
                Name = name,
                Age = age,
                Height = height,
                Weight = weight,
                FavoriteMovie = favoriteMovie
            };
            ConsoleHelper.PrintCandidates(candidate);

            //Задание 2
            Console.WriteLine("Задание 2");
            var passengerName = ConsoleHelper.ReadString("Введите ФИО");
            var trainNumber = ConsoleHelper.ReadString("Введите номер поезда");
            var departureDate = ConsoleHelper.ReadData("Введите дату отправления");
            var departureTime = ConsoleHelper.ReadTime("Введите время отправления");
            var biletType = ConsoleHelper.ReadType("Введите тип вагона (Platzkart, Coupe, SV, Lux)");
            var ticketPrice = ConsoleHelper.ReadPrice("Введите цену");
            var bilet = new Bilet
            {
                PassengerName = passengerName,
                TrainNumber = trainNumber,
                DepartureDate = departureDate,
                DepartureTime = departureTime,
                BiletType = biletType,
                TicketPrice = ticketPrice
            };
            ConsoleHelper.PrintBilet(bilet);

            //Задание 3
            Console.WriteLine("Задание 3");
            var nameKlient = ConsoleHelper.ReadString("Введите имя");
            var autoMarka = ConsoleHelper.ReadString("Введите марку автомобиля");
            var avtoClass = ConsoleHelper.ReadClass("Введите класс автомобиля");
            var arendaData = ConsoleHelper.ReadData("Введите дату начала аренды");
            var arendaFinish = ConsoleHelper.ReadData("Введите дату конца аренды ");
            var arendaPrice = ConsoleHelper.ReadPrice("Введите цену аренды за день");
            var klient = new AutoKlient
            {
                NameKlient = nameKlient,
                AutoMarka = autoMarka,
                AvtoClass = avtoClass,
                ArendaData = arendaData,
                ArendaFinish = arendaFinish,
                ArendaPrice = arendaPrice
            };
            ConsoleHelper.PrintAutoKlient(klient);

            //Задание 4
            Console.WriteLine("Задание 4");
            var nameStudent = ConsoleHelper.ReadString("Введите ФИО");
            var numberStudent = ConsoleHelper.ReadInt("Введите номер зачетной книжки");
            var nameFacultet = ConsoleHelper.ReadFacultets("Введите название факультета");
            var cursStudent = ConsoleHelper.ReadInt("Введите номер курса");
            var ballStudent = ConsoleHelper.ReadDouble("Введите средний балл");
            var dateStudent = ConsoleHelper.ReadData("Введите дату окончания учебы");
            var anketaStudenta = new Student 
            {
                NameStudent = nameStudent,
                NumberStudent = numberStudent,
                NameFacultet = nameFacultet,
                CursStudent = cursStudent,
                BallStudent = ballStudent,
                DateStudent = dateStudent

            };
            ConsoleHelper.PrintAnketaStudenta(anketaStudenta);
        }

    }
}

