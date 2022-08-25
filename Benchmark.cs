using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace AlgoHomework2
{
    public class BenchmarkTest
    {

        [Benchmark]
        public void TestFC()
        {
            FloatClass a = new FloatClass() { X = 0, Y = 0 };
            FloatClass b = new FloatClass() { X = 1000, Y = 2500 };

            FloatClassDistance(a, b);
        }

        [Benchmark]
        public void TestFS()
        {
            FloatStruct a = new FloatStruct() { X = 0, Y = 0 };
            FloatStruct b = new FloatStruct() { X = 1000, Y = 2500 };

            FloatStructDistance(a, b);
        }

        [Benchmark]
        public void TestSS()
        {
            FloatStruct a = new FloatStruct() { X = 0, Y = 0 };
            FloatStruct b = new FloatStruct() { X = 1000, Y = 2500 };

            ShortStructDistance(a, b);
        }

        [Benchmark]
        public void TestPS()
        {
            PointStruct a = new PointStruct() { X = 0, Y = 0 };
            PointStruct b = new PointStruct() { X = 1000, Y = 2500 };

            PointStructDistance(a, b);
        }

        static float FloatClassDistance(FloatClass s1, FloatClass s2)
        {
            float dx = s1.X - s2.X;
            float dy = s1.Y - s2.Y;

            return MathF.Sqrt((dx * dx) + (dy * dy));
        }

        static float FloatStructDistance(FloatStruct s1, FloatStruct s2)
        {
            float dx = s1.X - s2.X;
            float dy = s1.Y - s2.Y;

            return MathF.Sqrt((dx * dx) + (dy * dy));
        }

        static float ShortStructDistance(FloatStruct s1, FloatStruct s2)
        {
            float dx = s1.X - s2.X;
            float dy = s1.Y - s2.Y;

            return (dx * dx) + (dy * dy);
        }

        static double PointStructDistance(PointStruct s1, PointStruct s2)
        {
            double dx = s1.X - s2.X;
            double dy = s1.Y - s2.Y;

            return Math.Sqrt((dx * dx) + (dy * dy));
        }


    }
}
