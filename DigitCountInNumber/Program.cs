using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCountInNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите цифру");
            int digit = int.Parse(Console.ReadLine());

            int digitCount = (int)Math.Log10(number) + 1;    //формула для подсчета количества цифр в числе

            int digitNumber = 0; //цифра числа
            int count = 0; //счетчик цифр
            int tempNumber = number;  //временная переменная для хранения заданного числа

            for (int i = 0; i < digitCount; i++)
            {
                digitNumber = tempNumber % 10;
                tempNumber = tempNumber / 10;
                if (digitNumber == digit)  //определяем сколько раз встречается заданная цифра в заданном числе
                {
                    count++;
                }
            }

            Console.WriteLine($"Цифра {digit} в числе {number} встречается - {count} р.");
            Console.ReadLine();

        }
    }
}
