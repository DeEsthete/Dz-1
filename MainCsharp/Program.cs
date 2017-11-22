using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.ReadLine();
            Task2();
            Console.ReadLine();
            Task3();
            Console.ReadLine();
            Task4();
            Console.ReadLine();
            Task5();
            Console.ReadLine();
            Task6();
            Console.ReadLine();
            Task7();
            Console.ReadLine();
            Task8();
            Console.ReadLine();
            Task9();
            Console.ReadLine();
            Task10();
            Console.ReadLine();

        }

        private static void Task10()
        {
            for (int i = 20; i < 35; i++)
            {
                Console.WriteLine(i);
            }
            int b = 0;
            Console.WriteLine("Введите число 'b'");
            b = int.Parse(Console.ReadLine());
            for (int i = 10; i < b; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
            int a;
            Console.WriteLine("Введите число 'a'");
            a = int.Parse(Console.ReadLine());
            for (int i = a; i < 50; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
            Console.WriteLine("Введите число 'a' и 'b'");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void Task9()
        {
            int resist1, resist2;
            int voltage1, voltage2;
            int current1, current2;
            Console.WriteLine("Введите сопротивление и напряжение 1 электрической цепи");
            resist1 = int.Parse(Console.ReadLine());
            voltage1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление и напряжение 2 электрической цепи");
            resist2 = int.Parse(Console.ReadLine());
            voltage2 = int.Parse(Console.ReadLine());
            current1 = voltage1 / resist1;
            current2 = voltage2 / resist2;
        }

        private static void Task8()
        {
            int v1, m1;
            int v2, m2;
            int p1, p2;
            Console.WriteLine("Введите объем и массу 1 тела");
            v1 = int.Parse(Console.ReadLine());
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем и массу 2 тела");
            v2 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            p1 = v1 / m1;
            p2 = v2 / m2;
            if (p1 > p2)
            {
                Console.WriteLine("Плотность первого тела больше");
            }
            else if (p1 == p2)
            {
                Console.WriteLine("Плотности равны");
            }
            else
            {
                Console.WriteLine("Плотность второго тела");
            }
        }

        private static void Task4()
        {
            int number = 234;
            int week;
            const int DividerWeek = 7;
            week = number / DividerWeek;
            Console.Write("234 дней в неделях; ");
            Console.WriteLine(week);
        }

        private static void Task7()
        {
            //---
            double radius;
            double area;
            Console.WriteLine("Введите радиус окружности");
            String rad = Console.ReadLine();
            radius = int.Parse(rad);
            area = Math.PI * (radius * radius);
            Console.Write("Площадь окружности");
            Console.WriteLine(area);
            //---
            double a;
            double areakvad;
            Console.WriteLine("Введите сторону квадрата");
            String a1 = Console.ReadLine();
            a = int.Parse(a1);
            areakvad = a * a;
            Console.Write("Площадь квадрата");
            Console.WriteLine(areakvad);
            if (area < areakvad)
            {
                Console.WriteLine("Площадь квадрата больше");
            }
            else
            {
                Console.WriteLine("Площадь окружности больше");
            }
        }

        private static void Task6()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            if (A || B)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (A && B)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (B || C)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static void Task5()
        {
            int number;
            int ten, units;
            int SumOfDigits, ProductOfFigures;
            const int DividerTen = 10;
            Console.WriteLine("Введите двузначное число");
            number = int.Parse(Console.ReadLine());
            ten = number / DividerTen;
            units = number % DividerTen;
            Console.Write("Число десятков - ");
            Console.WriteLine(ten);
            Console.Write("Число единиц - ");
            Console.WriteLine(units);
            Console.Write("Сумма цифр - ");
            SumOfDigits = ten + units;
            Console.WriteLine(SumOfDigits);
            Console.Write("Произведение цифр - ");
            ProductOfFigures = ten * units;
            Console.WriteLine(ProductOfFigures);
        }

        private static void Task3()
        {
            int centimeter;
            int meters;
            const int CentimetersInMeters = 100;
            Console.WriteLine("Введите число в сантиметрах");
            String centimeter1 = Console.ReadLine();
            centimeter = int.Parse(centimeter1);
            meters = centimeter / CentimetersInMeters;
            Console.Write("Полных метров - ");
            Console.WriteLine(meters);
        }

        private static void Task2()
        {
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");
        }

        private static void Task1()
        {
            Console.WriteLine("1  2  2");
        }
    }
}
