using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void func1(double b, out double f, out int i)
        {
            f = b;
            i = (int)b; // Преобразование типов
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дробное число >");
            string s = Console.ReadLine();
            double f, b;
            int i;
            b = Convert.ToDouble(s); // Преобразование
                                            // типов
            func1(b, out f, out i);
            Console.WriteLine("Результаты от функции: f={0}, i={1}", f,
            i);
            Console.Write("Для продолжения нажмите " +
            "любую клавишу > ");
            Console.Read(); // Задержка экрана
        }
    }
}
