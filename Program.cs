using System;

namespace Actions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Показать таблицу умножения");
            Console.WriteLine("2 - Проверка на простоту");
            Console.WriteLine("3 - Фибоначчи (кто это..)");
1
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Вызов функции из другого файла1
                    whileNumber.whileNumbers();
                    break;
                case "2":
                    // Вызов другой функции из другого файла
                    EasyNumber.EasyNumbers();
                    break;
                case "3":
                    Fichan.Fichans();
                default:
                    Console.WriteLine("Неизвестный выбор.");
                    break;
            }
        }
    }
}
