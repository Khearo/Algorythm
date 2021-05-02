using System;

namespace Algorythm2
{
    class Program2
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Which task do you want to choose? \r\n-Recursion \r\n-Сycle");  //Меню выбора задания.
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Recursion":
                    Recursion();
                    break;

                case "Сycle":
                    Сycle();
                    break;
            }
            Recursion(); // Задание №2(b). Возведение в степень_Рекурсия 
            Сycle(); // Задание №2(а). Возведение в степень_Цикл
        }

        private static void Recursion()
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the pow:");
            int pow = int.Parse(Console.ReadLine());

            int result = Degree(number, pow);

            Console.WriteLine(result);


        }
        private static int Degree(int number, int pow)
        {
            //if (pow == 0 || pow == 1)
            //{
            //    return 1;
            //}

            return number * Degree(number, pow - 1);

        }

        private static void Сycle()
        {
            Console.WriteLine("Enter the number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the degree:");
            int b = int.Parse(Console.ReadLine());

            int result = a;
            for (int i = 1; i < b; i++)
            {
                if (b == 0 || b == 1)
                {
                    result = 1;
                }
                else
                {
                    result *= a;
                }
            }

            Console.WriteLine($"a^b: {result}");
        }
    }
}