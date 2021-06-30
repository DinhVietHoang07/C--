using System;

namespace Ex07
{
    class Calculate
    {
        public static void Addition(int vall, int val2)
        {
            Console.WriteLine(vall + val2);
        }
        public void Multiply (int vall, int val2)
        {
            Console.WriteLine(vall * val2);
        }
    }
    class StaticMethods
    {
        static void Main(string[] args)
        {
            Calculate.Addition(10, 50);
            Calculate objCal = new Calculate();
            objCal.Multiply(10, 20);
        }
    }
}
