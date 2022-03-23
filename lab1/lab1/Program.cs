using System;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1");
            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };
            a.Add(b);
            Console.WriteLine($"a = {a.Real} + {a.Imag}i");
            a.Substract(b);
            Console.WriteLine($"a = {a.Real} + {a.Imag}i");
            b.Multiply(a);
            Console.WriteLine($"b = {b.Real} + {b.Imag}i");
            b.Divide(a);
            Console.WriteLine($"b = {b.Real} + {b.Imag}i");
        }
    }
}
