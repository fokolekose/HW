using System;

namespace Calc
{
    internal class Calculator
    {
        public static void Main()
        {
            int number;

            Console.Write("Здравствуйте вас приветствует математическая программа.\nПожалуйста, введите число: ");
            string s = Console.ReadLine();
            if (s == "q")
            {
                return;
            }
            else number = Int32.Parse(s);

            Meths meth = new Meths(number);

            Console.WriteLine($"Факториал числа {number} = {meth.NumberFact}");
            Console.WriteLine($"Сумма чисел от 1 до {number} = {meth.NumberSum}");
            Console.WriteLine($"Максимальное четное число меньше {number} = {meth.NumberMaxEven}");
        }
    }
}