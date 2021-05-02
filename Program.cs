using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Channels;


namespace Algorythm  // by Aleksandr K. - Все задания выполняю на C#. Причина проста - я с 0 изучаю язык и хочу практиковаться именно на нем, чтобы не было в голове "каши". Однако, считаю не правильным проводить уроки на языке отличающимся от того, что ты учишь.
{
    class Program
    {
        static void Main(string[] args)
        {
            // Все, что успел сделать. Было интересно (: 
            
            InputYear();              // Задание №6.     "Год, года, лет."
            ChessField();             // Задание №7.     Шахматные поля.
            SquareCube();             // Задание №8.     Квадрат и куб числе из диапазона от а до b.
            AverageEvenNum();         // Задание №11.    Ср. арифм. четных положительных. А вот как реализовать еще с числом оконачивающимся на 8 не очень понял.
            MaxNumberOf4();           // Задание №2.     Максимальное число из 4х введенных.
            MaxNumberOf3();           // Задание №12.    Максимальное число из 3х введенных. PS, я совсем не понимаю разницу между 12 и 2 заданием...Нужно пояснение.   
            BMI();                    // Задание №1.     Индекс массы тела. 
            ExchangeWithout3RdVar();  // Задание №3(б).  Без использования 3й переменной.
            ExchangeWith3RdVar();     // Задание №3(а).  С использованием 3й переменной.
            Seasons();                // Задание №5.     Номер месяца == время года.
            RandomNumber();           // Задание №13(а). Под звездочкой что то не представляю как =\ Начав гуглить там совсем дебри уже для меня пока что.

        }

        private static void InputYear()
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            if (
                age % 10 == 1 && age != 11 &&
                age != 111) // нам нужна цифра в остатке 1, чтобы получить год, однако 11 и 111 - лет, поэтому пришлось их исключить.
            {
                Console.WriteLine($"Вам {age} год");
            }
            else if (age % 10 > 1 && age % 10 < 5 && age != 12 && age != 13 && age != 14) // Тут по аналогии.
            {
                Console.WriteLine($"Вам {age} года");
            }
            else // Тут просто все, в остальных условиях будет лет. Вроде бы работает так)))
            {
                Console.WriteLine($"Вам {age} лет");
            }

            Console.ReadKey();
        }

        private static void ChessField()
        {
            Console.WriteLine("Enter x1:");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1:");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2:");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1:");
            int y2 = int.Parse(Console.ReadLine());

            int p1 = (x1 + y1) % 2; // Т.к. черные поля имеют четную сумму координат, а белые нет - от этого и исходил. Решил ввести 2 новые переменные присвоив им выражение проверки на четность. 
            int p2 = (x2 + y2) % 2;

            if (p1 == p2)               // Соответственно, тут просто произвел проверку на равенство и выводим полученное.
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.ReadKey();
        }

        private static void SquareCube()
        {
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b:");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                int i2 = i * i;
                int i3 = i * i * i;

                Console.WriteLine($"number: {i}, square: {i2}, cube: {i3}");
            }
        }

        private static void AverageEvenNum()
        {
            int sum = 0;
            int number = 0;
            int count = 0;
            int[] numbers = new int[]{};

          /*  foreach (int n in numbers)
            {
                Console.WriteLine("Enter the number:");
                number = int.Parse(Console.ReadLine());

            }*/
              do  
              {
                  Console.WriteLine("Enter the number:");
                  number = int.Parse(Console.ReadLine());
                  
                  if (number > 0 && number % 10 == 8)  // Наверно как то так, но не уверен. Т.е, число > 0 и при делении на 10 остаток = 8, значит число содержит 8 в конце.
                  {
                      sum += number;
                      count++;
                  }
              } while (number != 0);
  
              
              double average = (double) sum / count;
              Console.WriteLine(average);
        }

        private static void MaxNumberOf4()
        {
              
            Console.WriteLine("Enter the first number:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            double n4 = double.Parse(Console.ReadLine());

            double maxVal1 = n1 > n2 ? n1 : n2;  // Вводим переменную в которую запишем большее значение из 2х используя тернарый оператор. 
            double maxVal2 = n3 > n4 ? n3 : n4;
            
            if (maxVal1 > maxVal2)            // Сравниваем 2 переменные и выводим результат.
            {
                Console.WriteLine($"The max number is {maxVal1}");
            }
            else
            {
                Console.WriteLine($"The max number is {maxVal2}");
            }
        }

        private static void MaxNumberOf3()
        {
            Console.WriteLine("Enter the first number:");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            double number3 = double.Parse(Console.ReadLine());

            double maxVal = Math.Max(number1, Math.Max(number2, number3));

            Console.WriteLine($"The max number is {maxVal}");

           /* if (number2 < number1 && number1 > number3)
            {
                Console.WriteLine($"The max number is {number1}");
            }

            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine($"The max number is {number2}");
            }
           
            else
            {
                Console.WriteLine($"The max number is {number3}");
            } */

            Console.ReadLine();
        }

        private static void ExchangeWithout3RdVar()
        {
            Console.WriteLine("Please enter an integer number a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an integer number b: ");
            int b = int.Parse(Console.ReadLine());

            b = a + b; //представляем переменную b в виде суммы a и b. В нее запишется новое значение, после чего находим новое значения для a вычтя из b a, аналогично и c b.
            a = b - a;
            b = b - a;

            Console.WriteLine($"After exchange of values without using 3rd variable : a = {a} , b = {b}");
            Console.ReadKey();
        }

        private static void ExchangeWith3RdVar()
        {
            Console.WriteLine("Please enter an integer number a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an integer number b: ");
            int b = int.Parse(Console.ReadLine());

            int c = a; // Вводим 3ю переменную для передачи ей значения одной из переменных.
            a = b;
            b = c;

            Console.WriteLine($"After exchange of values using 3rd variable : a = {a} , b = {b}");
            Console.ReadKey();
        }

        private static void BMI()
        {
            Console.WriteLine("Please input a height in m: ");
            double height = double.Parse(Console.ReadLine()); // Инициализируем переменную и преобразуем в к типу с плавающей запятой и запрашиваем ввод.

            Console.WriteLine("Please input a weight in kg: ");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2); // Формула вычисления индекса массы тела. Решил через Math.Pow возвести в квадрат, чтобы приучить себя использовать такие вещи.

            // Тут немного расширил условие задачи для выведения не только цифр, но состояния тела.
            if (bmi < 18)
            {
                Console.WriteLine($"Your bmi is {bmi} and you are underweight"); // Через интерполяцию выводим полученное, крайне удобно и быстро :)) 
            }
            else if (bmi > 18 && bmi < 25)
            {
                Console.WriteLine($"Your bmi is {bmi} and you are normal");
            }
            else
            {
                Console.WriteLine($"Your bmi is {bmi} and you are you are overweight");
            }

            Console.ReadKey(); // Чтобы окно не закрывалось сразу после выполнения кода.
        }

        private static void Seasons()
        {
            //Хотел попробовать именно через switch/case (мало уделяли ему времени) вместо if/else. Не знал, что он не поддерживает перечисление нескольких переменных внутри одного case, зато нашел решение и теперь знаю XD
            
            Console.WriteLine("Please enter the month number:");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("This is the winter month");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("This is the spring month");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("This is the summer month");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("This is the autumn month");
                    break;
                default:
                    Console.WriteLine("There is no season");
                    break;  
            }
        }

        private static void RandomNumber()
        {
            Random rand = new Random();             // Создаем объект типа Random для генерации.
            int number = rand.Next(1, 100);         // Next - возвращает случайное не отрицательное число в нужном нам диапазоне.
            Console.WriteLine(number);              // Выводим в консоль.
        } 
    }
}

