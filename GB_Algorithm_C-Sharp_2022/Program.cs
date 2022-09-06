using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        public class TestCase
        {
            public int N { get; set; }
            public bool Expected { get; set; }

        }

        static bool SimpleNumber(int n)
        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }


            if (d == 0)
            {
                Console.Write($"{n} is Simple = ");
                return true;

            }
            else
            {
                Console.Write($"{n} is Not Simple = ");
                return false;

            }

        }
        static void TestSimpleNumber(TestCase testCase)
        {
            try
            {
                var actual = SimpleNumber(testCase.N);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");

                }
                else
                {
                    Console.WriteLine("INVALID TEST");

                }
            }
            finally
            {
            }

        }


        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                N = 6,
                Expected = false

            };

            var testCase2 = new TestCase()
            {
                N = 5,
                Expected = true

            };

            var testCase3 = new TestCase()
            {
                N = 97,
                Expected = true

            };

            var testCase4 = new TestCase()
            {
                N = 83,
                Expected = false

            };

            var testCase5 = new TestCase()
            {
                N = 101,
                Expected = false

            };

            TestSimpleNumber(testCase1);
            TestSimpleNumber(testCase2);
            TestSimpleNumber(testCase3);
            TestSimpleNumber(testCase4);
            TestSimpleNumber(testCase5);
        }
    }
}