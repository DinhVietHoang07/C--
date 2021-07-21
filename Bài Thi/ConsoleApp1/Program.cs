using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.Write("Nhap vao ban kinh hinh tron: ");

            double r = double.Parse(Console.ReadLine());

            double chuvi = Math.PI * r * 2;

            double dientich = Math.PI * r * r;

            Console.WriteLine("Hinh tron ban kinh: {0}, co chu vi: {1}, dien tich: {2}, r, chuvi, dientich");

            Console.ReadLine();

        }
    }
}
