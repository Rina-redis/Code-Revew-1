using System;

namespace Abramyan_Code_review_1
{
    class Program
    {
        //integers
        static void Integer3()
        {
            int bites = int.Parse(Console.ReadLine());
            int kiloBites = bites / 1024;
            Console.WriteLine($"Количество байтов равняеться {kiloBites}");
        }
        static void Integer6()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number.ToString().Length; i++)
            {
                int tens = 10;
                while (number > 10)
                {

                    int res = number % tens;
                    int count = number / tens;
                    if (count > 10)
                    {
                        tens *= 10;
                    }
                    if (count < 10)
                    {
                        number -= tens * count;
                        tens = 10;
                        Console.WriteLine(count);
                    }

                }
                Console.WriteLine(number);
            }
        }
        static void Integer9()
        {
            int number = int.Parse(Console.ReadLine());
            int result = number / 100;
            Console.WriteLine(result);
        }
        static void Integer12()
        {
            int number = int.Parse(Console.ReadLine());
            int firstNumber, secondNumber, thirdNumber;
            firstNumber = number / 100;
            secondNumber = (number % 100) / 10;
            thirdNumber = number % 10;
            Console.WriteLine("Перевернутое число {0}{1}{2}", thirdNumber, secondNumber, firstNumber);
        }
        static void Integer15()
        {
            int number = int.Parse(Console.ReadLine());
            int hundrets = number / 100;
            int tens = (number - hundrets * 100) / 10;
            int ones = (number - hundrets * 100) - (tens * 10);
            int newNumber = tens * 100 + hundrets * 10 + ones;
            Console.WriteLine(newNumber);
        }
        static void Integer18()
        {
            int number = int.Parse(Console.ReadLine());
            int thousend = number / 1000;
            Console.WriteLine(thousend);
        }
        static void Integer21()
        {
            int seconds = int.Parse(Console.ReadLine());
            int secondsInLastMin = seconds % 60;
            Console.WriteLine("Секунд в останній хвилині " + secondsInLastMin);
        }
        static void Integer24()
        {
            int dayNumber = int.Parse(Console.ReadLine());
            int day = dayNumber % 6;
            Console.WriteLine("Номер дня :" + day);
        }
        static void Integer27()
        {
            int dayNumber = int.Parse(Console.ReadLine());
            int day = (dayNumber % 6) + 4;
            Console.WriteLine("Номер дня :" + day);
        }
        static void Integer30()
        {
            int yearNumber = int.Parse(Console.ReadLine());
            int centuary = (yearNumber / 100) + 1;
            Console.WriteLine(centuary + " Столетие");
        }

        //booleans
        static void Boolean3()
        {
            int number = int.Parse(Console.ReadLine());
            bool result = number % 2 == 0 ? (true) : (false);
            if (result)
                Console.WriteLine("Еven");
            else
                Console.WriteLine("Odd");
        }
        static void Boolean15()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            if (firstNumber >= 0 && secondNumber >= 0 && thirdNumber <= 0 || firstNumber >= 0 && thirdNumber >= 0 && secondNumber <= 0 || thirdNumber >= 0 && secondNumber >= 0 && firstNumber <= 0)
                Console.WriteLine("Дело в шяпе");
        }
        static void Boolean21()
        {
            int number = int.Parse(Console.ReadLine());
            int hundrets = number / 100;
            int tens = (number - hundrets * 100) / 10;
            int ones = (number - hundrets * 100) - (tens * 10);
            if (hundrets > tens && tens > ones)
                Console.WriteLine("Дело в шяпе");
        }
        static void Boolean24()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int D = (b ^ 2 - 4 * a * c);
            bool result = D > 0 ? (true) : (false);
            if (result)
                Console.WriteLine("D>0");
            else
                Console.WriteLine("D<0");

        }
        static void Boolean27()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x < 0)
                Console.WriteLine("Число лежить у 2 або 3 чверті");
            else
                Console.WriteLine("Число лежить у 1 або 4 чверті");
        }
        static void Boolean33()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a + b > c || a + c > b || b + c > a)
                Console.WriteLine("Треугольник существует");
            if (a == b && b == c)
                Console.WriteLine("Треугольник равносторонний");
        }
        static void Boolean36()//под вопросом
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            if (x1 == x2 || y1 == y2)
                Console.WriteLine("Може перейти");
        }

        //If
        static void If15()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > c && b > c)
            {
                Math(a, b);
            }
            if (a > b && c > b)
            {
                Math(a, c);
            }
            if (b > a && c > a)
            {
                Math(b, c);
            }

            void Math(int a, int b)
            {
                int result = a + b;
                Console.WriteLine("Сумма двох більших чисел:" + result);
            }
        }
        static void If21()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
                Console.WriteLine(0);
            if (x == 0)
                Console.WriteLine(1);
            if (y == 0)
                Console.WriteLine(2);
            if (x != 0 && y != 0)
                Console.WriteLine(3);
        }
        static void If24()
        {
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                double f = 2 * Math.Sin(x);
                Console.WriteLine(f);
            }
            else
            {
                double f = 6 - x;
                Console.WriteLine(f);
            }
        }
        static void If27()
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            if (number < 0)
                result = 0;
            if (number % 2 == 0 || number == 0)
                result = 1;
            if (number % 2 == 1)
                result = -1;
            Console.WriteLine(result);
        }
        static void If30()
        {
            string answer = "";
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                answer += "чётное";
            if (number % 2 == 1)
                answer += "нечётное";
            if (number / 100 >= 1)
                answer += " трёхзначное";
            if (number / 100 < 1 && (number % 100) / 10 >= 1)
                answer += " двухзначное";
            if (number / 100 < 1 && (number % 100) / 10 < 1)
                answer += " однозначное";
            Console.WriteLine(answer + " число");

        }
        static void Main(string[] args)
        {
            
        }
    }
}
