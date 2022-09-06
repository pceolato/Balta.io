// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(RetornaTriangulo(15, 7.5));
        }

        static double RetornaTriangulo(int bse, double altura) 
        {
            var area = (bse * altura) / 2;
            return area;
        }

    }
}
