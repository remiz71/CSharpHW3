using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHW3
{
    class Program
    {
        static void Main(string[] args)
        {
#if false // TASK1
            //TASK 1

            int a, b, c;
            double x;
            Console.WriteLine("Программа для решения квадратных уравнений!!!");
            Console.Write("Введите А : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B : ");
            b= Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите C : ");
            c= Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Ошибка, а не может быть равным нулю!");
            } 
            else if (b!=0 && c != 0)
            {
                int D = b*b - 4 * a * c;
                Console.WriteLine("Дискриминант = {0}", D);
                if (D < 0) Console.WriteLine("Корней нет!");
                if (D == 0)
                {
                    x = (-b + Math.Sqrt(D)) / 2 * a;
                    Console.WriteLine("Один корень уравнения, х = {0}", x);
                }
                else if (D>0)
                {
                    x = (-b + Math.Sqrt(D)) / 2 * a;
                    Console.WriteLine("Два корня уравнения:\nх1 = {0}", x);
                    x = (-b - Math.Sqrt(D)) / 2 * a;
                    Console.WriteLine("х2 = {0}", x);
                }
            }
            else if (b == 0 && c!=0)
                {
                    x = Math.Sqrt(-c / a);
                    if(-c / a <0) Console.WriteLine("Корней нет!");
                    else Console.WriteLine("Два корня уравнения : {0} и -{0}",x);
                }
            else if (b != 0 && c ==0)
            {
                x = -b / a;
                Console.WriteLine("Два корня уравнения : 0 и {0}", x);
            }
#endif
            //-------------------------------------------------------------------------//

#if false //TASK2
            // TASK 2

            Console.WriteLine("Программа для разложения числа на простые множители!");
            Console.Write("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int div = 2;
            Console.Write("{0} = ", N);
            while (N > 1)
            {
                while (N%div == 0)
                {
                    Console.Write("{0}  ", div);
                    N /= div;
                }
                div++;
            }
#endif
            //-------------------------------------------------------------------------//

#if true //TASK3

            Console.WriteLine("Программа по поиску совершенных чисел!");
            long N;
            for (N = 2; N < 10000; N++) // больше 8128 не ищет или делает это очень долго
            {
                long sum = 0;
                for (long i = 1; i <= N / 2; i++)
                {
                    if (N % i == 0) sum += i;
                }
                if (sum == N) Console.WriteLine("Число {0} - совершенное! ", N);
                N++;
            }



#endif






        }
    }
}
