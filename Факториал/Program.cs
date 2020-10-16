using System;

namespace Факториал
{
    class Program
    {
       static void Main(string[] args)
       {
            while (true)
            {
                ulong n;
                ulong i;
                double summa = 1;
                ulong schetchik = 0;
                Console.Write("Введите число для факториала: ");
                while (!ulong.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Введите корректное число");
                }
                Console.Write("Вывод количества символов окончательного результата: ");
                for (i = 1; i <= n; i++)
                {
                    summa *= i;
                    while (summa >= 1)
                    {
                        schetchik += 1;
                        summa /= 10;
                    }
                }
                Console.WriteLine(schetchik);
                ulong[] array = new ulong[schetchik];
                array[schetchik - 1] = 1;
                ulong j;
                for (i = 1; i <= n; i++)
                {
                    for (j = 0; j < schetchik; j++)
                    {
                        array[schetchik - 1 - j] *= i;
                    }
                    for (j = 0; j < schetchik; j++)
                    {
                        while (array[schetchik - 1 - j] >= 10)
                        {
                            array[schetchik - 2 - j] += array[schetchik - 1 - j] / 10;
                            array[schetchik - 1 - j] %= 10;
                        }
                    }
                }
                Console.WriteLine("Вывод факториала: ");
                for (j = 0; j < schetchik; j++)
                {
                    Console.Write($"{array[j]} ");
                }
                Console.WriteLine();
            }
       }
    }
}
