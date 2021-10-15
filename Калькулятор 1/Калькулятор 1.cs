using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_
{
    class Calc
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите выражение: ");
                string s = Console.ReadLine();
                string[] s1 = s.Split('+', '-', '/', '*', '%', '^');
                int a = Convert.ToInt32(s1[0]);
                int b = Convert.ToInt32(s1[1]);
                if (s.IndexOf('+') >= 0)
                {
                    Console.WriteLine("Ваш ответ: " + (a + b));
                }
                if (s.IndexOf('-') >= 0)
                {
                    Console.WriteLine("Ваш ответ: " + (a - b));
                }
                if (s.IndexOf('/') >= 0)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль");
                    }
                    else Console.WriteLine("Ваш ответ: " + (a / b));
                }
                if (s.IndexOf('*') >= 0)
                {
                    Console.WriteLine("Ваш ответ: " + (a * b));
                }
                if (s.IndexOf('^') >= 0)
                {
                    Console.WriteLine("Ваш ответ: " + Math.Pow(a, b));
                }
                if (s.IndexOf('%') >= 0)
                {
                    Console.WriteLine("Ваш ответ: " + (a % b));
                }

            }
        }
    }
}
