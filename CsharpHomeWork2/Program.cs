using System;

namespace CsharpHomeWork2
{
    class Program
    {
    static int MinNum()
        {
            Console.Write("Введите три целых числа:\n a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c= ");
            int c = Convert.ToInt32(Console.ReadLine());
            int min = a;
            if (b<min) min = b;
            if (c<min) min = c;   
            return min;
         }
    static void Main(string[] args)
        {
            Console.WriteLine($"Наименьшее из трех введенных чисел равно {MinNum()}");
            Console.ReadLine();
        }
    }
}
