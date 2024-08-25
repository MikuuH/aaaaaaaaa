using System;

namespace Actions
{
    public static class whileNumber
    {
        public static void whileNumbers()
        {
            Console.Write("Введите число для таблицы умножения: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                for (int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        int result = i * j;
                        Console.WriteLine($"{i} * {j} = {result}");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Число должно быть от 1 до 10.");
            }
        }
    }
}
