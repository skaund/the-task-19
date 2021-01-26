using System;

namespace test12
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b;
            string perem12;

            Console.WriteLine("Введите первое число: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию, которую вы хотите сделать с введенными числами: '+', '-', '*', '/'");
            perem12 = Console.ReadLine();

            switch(perem12)
            {
                case "+":
                    Console.WriteLine("Сложением введенных вами чисел является:");
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine("Вычитанием введенных вами чисел является:");
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine("Произведением введенных вами чисел является:");
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    if (b == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine("Частым введенных вами чисел является:");
                        Console.WriteLine(a / b);
                    break;

                default:
                    Console.WriteLine("Произошла ошибка, введите конкретное значение");
                        break;
            }

            Console.WriteLine("Для окончания работы нажмите Enter");
           
        }
    }
}