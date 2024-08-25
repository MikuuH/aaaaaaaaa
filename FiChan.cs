using System;

namespace Actions
{
    public static class Fichan
    {
        public static void Fichans()
        {
            Console.Write("Введите количество чисел Фибоначчи: ");
            
            int n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Введено некорректное число. Пожалуйста, введите положительное целое число.");
                return;
            }

            // Специальные случаи для чисел 1 и 2
            if (n == 1)
            {
                Console.WriteLine("F1) 1");
                return;
            }
            else if (n == 2)
            {
                Console.WriteLine("F1) 1");
                Console.WriteLine("F2) 1");
                return;
            }

            // Вывод первых двух чисел Фибоначчи
            Console.WriteLine("F1) 1");
            Console.WriteLine("F2) 1");

            int n_1 = 1;
            int n_2 = 1;

            // Вывод оставшихся чисел Фибоначчи
            for (int i = 3; i <= n; ++i)
            {
                var n_3 = n_1 + n_2;
                Console.WriteLine($"F{i}) {n_3}");
                n_1 = n_2;
                n_2 = n_3;
            }
        }
    }
}
