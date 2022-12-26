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
            Console.WriteLine("Программа находит первую цифру введенного числа");

            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());  //считываем значение переменной number

            int firstDigit = 0;
            int digitCount = (int)Math.Log10(number) + 1; //находим количество цифр в числе


            for (int i = 1; i < digitCount; i++)
            {
                firstDigit = number / 10;   //определяем крайнюю левую цифру числа
                number = firstDigit;
            }

            Console.WriteLine($"Первая цифра данного числа {number} = {firstDigit}");
            Console.ReadKey();
        }
    }
}
