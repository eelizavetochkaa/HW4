using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW4
{
    enum Level
    {
        Mild,
        Medium,
        Severe
    }
    struct Ded
    {
        public string Name;
        public Level level_of_grumbling;
        public string[] Grumbling;
        public int Blows;

        public Ded(string name, Level level, string[] grumbling)
        {
            Name = name;
            level_of_grumbling = level;
            Grumbling = grumbling;
            Blows = 0;
        }

        public int CheckBadWords(params string[] badwords)
        {
            int BlowsCount = 0;

            foreach (string phrase in Grumbling)
            {
                foreach (string word in badwords)
                {
                    if (phrase.Contains(word))
                    {
                        BlowsCount++;
                    }
                }
            }
            Blows += BlowsCount;
            return BlowsCount;

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Номер 1");
                Console.WriteLine("Программа выводит 20 случайных чисел из массива");
                int[] numbers = new int[20];
                Random rand = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rand.Next(1, 100);
                }
                Console.WriteLine("Исходный массив:");
                PrintArray(numbers);
                Console.WriteLine("Введите 2 порядковые номера элемента, которые необходимо поменять местами");
                int i1 = int.Parse(Console.ReadLine());
                int i2 = int.Parse(Console.ReadLine());
                int a;
                a = numbers[i1 - 1];
                numbers[i1 - 1] = numbers[i2 - 1];
                numbers[i2 - 1] = a;
                Console.WriteLine("Получившийся массив");
                PrintArray(numbers);



                Console.WriteLine("Номер 2");
                Console.WriteLine("Программа выводит сумму элементов массива, их произведение и среднее арифметическое");
                int[] nums = { 1, 2, 3, 4, 5 };

                int sum = Sum1(nums);
                Console.WriteLine("Сумма элементов массива: " + sum);

                int composition = 1;
                Composition1(ref composition, nums);
                Console.WriteLine("Произведение элементов массива: " + composition);

                double average;
                Average1(out average, nums);
                Console.WriteLine("Среднее арифметическое элементов массива: " + average);

                Console.WriteLine("Номер 3");
                Console.WriteLine("");
                while (true)
                {
                    Console.WriteLine("Введите число от 0 до 9 или 'exit'/'закрыть' для выхода:");
                    string line = Console.ReadLine();

                    if (line.ToLower() == "exit" || line.ToLower() == "закрыть")
                    {
                        break;
                    }

                    try
                    {
                        int number = int.Parse(line);

                        if (number >= 0 && number <= 9)
                        {
                            Paint(number);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка: число должно быть от 0 до 9");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(3000);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка: введено некорректное значение");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(3000);
                    }
                }
                Console.WriteLine("Номер 4");

                Ded[] d = new Ded[5];

                d[0] = new Ded("Витя", Level.Mild, new string[] { "Безобразники!", });
                d[1] = new Ded("Саня", Level.Medium, new string[] { "Сволочи!", "Нелюди!" });
                d[2] = new Ded("Илья", Level.Severe, new string[] { "Свиньи", "Дураки!", "Негодяи" });
                d[3] = new Ded("Генрих", Level.Medium, new string[] { "Гады!", "Идиоты!" });
                d[4] = new Ded("Аристарх", Level.Mild, new string[] { "Неудачники!", "Собаки!" });

                Console.WriteLine("Введите список слов, за которые бабка ставит фигнал из списка: \n Безобразники!\n Сволочи! \n Нелюди! \n Свиньи \n Дураки! \n Негодяи! \n Гады! \n Идиоты! \n Неудачники! \n Собаки! ");
                string[] badwords = Console.ReadLine().Split(' ');

                int totalblows = 0;

                foreach (Ded grandpa in d)
                {
                    int blows = grandpa.CheckBadWords(badwords);
                    totalblows += blows;

                    Console.WriteLine(grandpa.Name + " получил " + blows + " синяк(а) от бабки");
                    Console.WriteLine("Количество фингалов: " + totalblows);
                }

                
                Console.ReadKey();


            }
            static void PrintArray(int[] numbers)
            {
                foreach (int i in numbers)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            static int Sum1(params int[] array)
            {
                int sum = 0;
                foreach (int num in array)
                {
                    sum += num;
                }
                return sum;
            }

            static void Composition1(ref int composition, params int[] array)
            {
                foreach (int num in array)
                {
                    composition *= num;
                }
            }

            static void Average1(out double average, params int[] array)
            {
                int sum = Sum1(array);
                average = (double)sum / array.Length;
            }
            static void Paint(int number)
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("####");
                        Console.WriteLine("#  #");
                        Console.WriteLine("#  #");
                        Console.WriteLine("#  #");
                        Console.WriteLine("####");
                        break;
                    case 1:
                        Console.WriteLine("  ##");
                        Console.WriteLine(" ###");
                        Console.WriteLine("# ##");
                        Console.WriteLine("  ##");
                        Console.WriteLine(" ###");
                        break;
                    case 2:
                        Console.WriteLine("####");
                        Console.WriteLine("   #");
                        Console.WriteLine("####");
                        Console.WriteLine("##  ");
                        Console.WriteLine("####");
                        break;
                    case 3:
                        Console.WriteLine("####");
                        Console.WriteLine("  ##");
                        Console.WriteLine("####");
                        Console.WriteLine("  ##");
                        Console.WriteLine("####");
                        break;
                    case 4:
                        Console.WriteLine("#  #");
                        Console.WriteLine("#  #");
                        Console.WriteLine("####");
                        Console.WriteLine("   #");
                        Console.WriteLine("   #");
                        break;
                    case 5:
                        Console.WriteLine("####");
                        Console.WriteLine("#   ");
                        Console.WriteLine("####");
                        Console.WriteLine("  ##");
                        Console.WriteLine("###");
                        break;
                    case 6:
                        Console.WriteLine("####");
                        Console.WriteLine("#  ");
                        Console.WriteLine("####");
                        Console.WriteLine("#  #");
                        Console.WriteLine("####");
                        break;
                    case 7:
                        Console.WriteLine("####");
                        Console.WriteLine("   #");
                        Console.WriteLine("  # ");
                        Console.WriteLine(" #  ");
                        Console.WriteLine(" #  ");
                        break;
                    case 8:
                        Console.WriteLine("####");
                        Console.WriteLine("#  #");
                        Console.WriteLine("####");
                        Console.WriteLine("#  #");
                        Console.WriteLine("####");
                        break;
                    case 9:
                        Console.WriteLine("####");
                        Console.WriteLine("#  #");
                        Console.WriteLine("####");
                        Console.WriteLine("   #");
                        Console.WriteLine("####");
                        break;
                    default:
                        break;


                }
            }
        }
    }
}

