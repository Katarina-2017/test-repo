using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDigitOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = 0;

            for (int i = 0; i < 1; i++)
            {
                firstDigit = number % 10;   //определяем первую цифру числа
            }

            Console.WriteLine($"Первая цифра числа = {firstDigit}");
            Console.ReadKey();
        }
    }
}
