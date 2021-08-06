using System;

namespace CsharpHomeWork2
{
    class Program
    {




        static int MinNum()
        /* Лебедев Максим
         * Задание 1.
         *  Написать метод, возвращающий минимальное из трёх чисел.
         */
        {
            Console.Write("Введите три целых числа:\n a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c= ");
            int c = Convert.ToInt32(Console.ReadLine());
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }


        public static int Count(int a)
        /* Lebedev Maksim  
         * Задание 2
         * Написать метод подсчета количества цифр числа.
         */
        {
            int countNumber = (int)Math.Log10(a) + 1;
            return countNumber;
        }





        static void Main(string[] args)

        {
            // Для 1 задания
            //Console.WriteLine($"Наименьшее из трех введенных чисел равно {MinNum()}");
            //Console.ReadKey();



            /* Для 2 задания
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В числе {Count(number)} цифры");
            Console.ReadKey();
            */



            /* Lebedev Maksim
             * Задание 3
             *С клавиатуры вводятся числа, пока не будет введен 0. 
             *Подсчитать сумму всех нечетных положительных чисел.
             */
            // int s = 0;
            // Console.WriteLine("Введите целое число: ");
            // int a = int.Parse(Console.ReadLine());
            // while (a != 0)
            // {
            //    if (a > 0 && a % 2 != 0 && a != -a) { s = s + a; }
            //     a = int.Parse(Console.ReadLine());
            //}
            //Console.Write($"Сумма всех нечетных, положительных чесел составила: {s}");
            // Console.ReadKey;
            // }



            /* Lebedev Maksim
             * Задание 4
             * Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
             * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
             * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
             * С помощью цикла do while ограничить ввод пароля тремя попытками.
             *
             */
            int count = 3;
            string login = "root";
            string password = "GeekBrains";

            Console.Write("Добро пожаловать.\n Используте свой логин и пароль для входа в систему.\nУ Вас 3 попытки.\n");

            do
            {

                Console.Write("Введите логин: ");
                String UserName = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string UserPassword = Console.ReadLine();

                if (login == UserName && password == UserPassword)
                {
                    Console.Clear();
                    Console.Write($"Добро пожаловать {UserName}");
                    Console.ReadKey();
                    break;

                }
                else
                    Console.Write("Логин или пароль введен неверно.");
                    count--;
                    Console.WriteLine($"У вас осталось {count} попыток");

                if (count == 0 && login != UserName && password != UserPassword)
                {
                    Console.Clear();
                    Console.WriteLine("Все попытки исчерпаны, приходите в следующий раз");
                    Console.ReadKey();
                }

            }
            while (count != 0);

        }
    }
}

