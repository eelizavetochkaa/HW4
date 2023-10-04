using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков5
{
    internal class Program
    {
        static int FindMax(int first, int second)
        {


            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static void ChangeVariable(ref int a, ref int b)
        {
            int c;

            c = a;

            a = b;

            b = c;

            Console.WriteLine($"Первое число = {a}, второе число = {b}");


        }

        static bool Factorial(ref int x)
        {
            try
            {
                checked /// замечает переполнение, выбрасывает ошибку, если она есть
                {
                    int F = 1;
                    for (int i = 1; i <= x; i++)
                    {
                        F *= i;
                    }
                    x = F;
                }
            }
            catch (OverflowException) /// ловит ошибку, название этой ошибки
            {
                return false;
            }
            return true;


        }
        static int Factorial1(int n1)
        {
            int f;
            if (n1 <= 1)
            {
                return 1;
            }
            else
            {
                return n1 * Factorial1(n1 - 1);
            }
            return f;
        }
        static int NOD(int a2, int b2)
        {
            if (a2 == 0)
            {
                return b2;
            }
            else
            {
                int min = Math.Min(a2, b2);
                int max = Math.Max(a2, b2);
                return NOD(max - min, min);
            }

        }
        static int Fibonachi(ref int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                int x1 = 1;
                int x2 = 1;
                int summa = 0;
                int i = 2;
                while (i <= n)
                {
                    summa = x1 + x2;
                    x1 = x2;
                    x2 = summa;
                    i++;
                }
                return summa;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Программа возвращает наибольшее из 2х чисел");
            Console.WriteLine("Введите первое число");
            int firstt = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int secondd = int.Parse(Console.ReadLine());
            Console.WriteLine("Наибольшее число = " + FindMax(firstt, secondd));

            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("Программа меняет местами значения параметров");

            Console.WriteLine("Введите первое число");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = int.Parse(Console.ReadLine());
            ChangeVariable(ref num1, ref num2);

            Console.WriteLine("Упражнение 5.3");
            Console.WriteLine("Программа вычисляет факториал числа");
            Console.WriteLine("Введите число, факториал которого хотите узнать");
            int n = int.Parse(Console.ReadLine());
            if (Factorial(ref n))
            {
                Console.WriteLine("Успешно. Факториал = " + n);
            }

            else
            {
                Console.WriteLine("Неуспешно");
            }

            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("Рекурсивный метод вычисления факториала числа");
            Console.WriteLine("Введите число, факториал которого хотите узнать");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Факториал числа {n2} = " + Factorial1(n2));

            Console.WriteLine("Домашняя работа 5.1");
            Console.WriteLine("Нахождение НОД 2х чисел по алгоритму Евклида");
            Console.WriteLine("Введите первое число");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"НОД этих двух чисел = " + NOD(a1, b1));

            Console.WriteLine("Домашнее задание 5.2");
            Console.WriteLine("Вычисление n-ого члена ряда Фибоначчи");
            Console.WriteLine("Введите номер члена Фибонначи, который хотите найти");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"{number} - ый член Фибоначчи = " + Fibonachi(ref number));

            Console.ReadKey();
        }
    }
}
