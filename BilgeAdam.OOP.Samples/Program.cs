using BilgeAdam.OOP.Common1;
using System;

namespace BilgeAdam.OOP.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 6;
            var b = 7;
            var d = new Dummy { Value = 10 };

            var sum1 = Sum(ref a, ref b);
            var updated = Update(d);
            var converted = Convert("45a", out var n);
            if (converted)
            {
                Console.WriteLine(n);
            }

            var b1 = new Box(3);
            var b2 = new Box(3, 4, 5);
            var volume = b1 + b2;
            var diffF = b1 - b2;
            var diffS = b2 - b1;
            var newVolume1 = GetVolume(5);
            var newVolume2 = GetVolume("2");
            var newVolume3 = GetVolume("2a");

            Console.ReadLine();
        }
        public static int GetVolume(Box box)
        {
            return box.Edge1 * box.Edge2 * box.Edge3;
        }

        public static int Sum(ref int a, ref int b)
        {
            a = 3;
            b = 8;
            return a + b;
        }

        public static bool Convert(string value, out int number)
        {
            try
            {
                var n = int.Parse(value);
                number = n;
                return true;
            }
            catch
            {
                number = 0;
                return false;
            }
        }

        public static Dummy Update(Dummy dummy)
        {
            dummy.Value = 12;
            return dummy;
        }
    }

    class Dummy
    {
        public int Value { get; set; }
    }
}
