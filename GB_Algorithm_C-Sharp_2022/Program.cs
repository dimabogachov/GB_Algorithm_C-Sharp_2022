using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int Fib(int x)
        {
            if (x == 0) return 0;

            int prev = 0;
            int next = 1;
            for (int i = 1; i < x; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }
        static void Main(string[] args)
        {
            Console.Write("Ведите номер в последовательности Фибоначчи : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int Recursion = Fibonacci(N+2);
            int Circle = Fib(N+2);

            Console.WriteLine($"{N}-ое число Фибоначчи = {Recursion} [Рекурсия]");
            Console.WriteLine($"{N}-ое число Фибоначчи = {Circle} [цикл]");
            
        }

    }

}
