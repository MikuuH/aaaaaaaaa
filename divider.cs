
using System;
namespace Actions
{
    public static class divider
    {
        public static void dividers()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i);
                    
                }
            }
        }
    }
}