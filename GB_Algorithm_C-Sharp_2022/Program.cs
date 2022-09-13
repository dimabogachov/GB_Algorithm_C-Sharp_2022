using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;



namespace Lesson_3
{
   
        public class PointClass
        {
            public int X;
            public int Y;
        }
        public struct PointStruct
        {
            public int X;
            public int Y;
        }

    public class BenchmarkClass
    {


        public static float PointDistanceClass(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static float PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X; // непонятно как вынести значения аргументов pointOne и pointTwo,
                                               // чтобы они были видны для остальных методов - PointDistanceDouble и PointDistanceShort
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceShort(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }

        [Benchmark]
        public void TestDistanceClass()
        {
            var point1 = new PointClass() { X = 100, Y = 200 };
            var point2 = new PointClass() { X = 200, Y = 300 };

            PointDistanceClass(point1, point2);
        }
        [Benchmark]
        public void TestDistance()
        {
            var Point1_S = new PointStruct() { X = 100, Y = 200 };
            var Point2_S = new PointStruct() { X = 200, Y = 300 };
            PointDistance(Point1_S, Point2_S);
        }

        [Benchmark]
        public void TestDistanceDouble()
        {
            var Point1_S = new PointStruct() { X = 100, Y = 200 };
            var Point2_S = new PointStruct() { X = 200, Y = 300 };
            PointDistanceDouble(Point1_S, Point2_S);
        }
        [Benchmark]
        public void TestDistanceShort()
        {
            var Point1_S = new PointStruct() { X = 100, Y = 200 };
            var Point2_S = new PointStruct() { X = 200, Y = 300 };
            PointDistanceShort(Point1_S, Point2_S);
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
               
            /*  Console.WriteLine(PointDistanceClass(point1, point2));

              Console.WriteLine(PointDistance(Point1_S, Point2_S));

              Console.WriteLine(PointDistanceDouble(Point1_S, Point2_S));

              Console.WriteLine(PointDistanceShort(Point1_S, Point2_S));
            */
        }
        }
    
}