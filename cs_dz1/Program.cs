using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zadanie1();

            zadanie2();

            zadanie3();            
        }

        static void zadanie1()
        {
            Console.WriteLine("Задание 1 с квадратом в прямоугольнике");

            uint A, B, C, count;

            Console.Write("Введите размер А: ");
            A = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Введите размер B: ");
            B = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Введите размер C: ");
            C = Convert.ToUInt32(Console.ReadLine());

            if (A < C || B < C)
                Console.WriteLine("Размер С слишком большой");

            else
            {
                uint CinA = A / C;
                uint CinB = B / C;

                count = CinA * CinB;
                Console.WriteLine("Количество квадратов \"C\" размещенных на прямоугольнике: {0}", count);

                float squareOstat = (A % C) * (B % C);
                Console.WriteLine("площадь незанятой части прямоугольника: {0}", squareOstat);
            }
        }


        static void zadanie2()
        {
            Console.WriteLine("\nЗадание 2 лесенка чисел");
            int a, b;

            Console.Write("Введите А: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (a > b)
                Console.WriteLine("А меньше В");

            else
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i + " ");
                    }

                    Console.WriteLine();
                }

            }

        }


        static void zadanie3()
        {
            Console.WriteLine("\nЗадание 3 перевернутое число");

            int a;

            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Перевернутое число:");

            for (; a > 0; a /= 10)
            {
                Console.Write(a % 10);
            }

            Console.WriteLine();
        }
    }
}
