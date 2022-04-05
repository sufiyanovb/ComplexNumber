using System;

namespace ComplexNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var cn1 = new ComplexNumber(2, 3);
            var cn2 = new ComplexNumber(5, -7);

            var a = cn1*cn2;

            Console.WriteLine("Hello World!");


        }
    }
}
