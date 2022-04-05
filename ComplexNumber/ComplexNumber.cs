using System;

namespace ComplexNumber
{
    public class ComplexNumber 
    {

        private readonly double _a;
        private readonly double _b;

        public ComplexNumber(double a, double b)
        {
            _a = a;
            _b = b;
        } 

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a._a + b._a, a._b + b._b);
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a._a - b._a, a._b - b._b);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a._a * b._a - a._b * b._b, a._b * b._a + a._a * b._b);
        }
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(Math.Round((a._a * b._a + a._b * b._b) / (Math.Pow(b._a, 2) + Math.Pow(b._b, 2)), 3),
                                     Math.Round((a._b * b._a - a._a * b._b) / (Math.Pow(b._a, 2) + Math.Pow(b._b, 2)), 3));
        }

        public static ComplexNumber ConjugateNumber(ComplexNumber a)
        {
            return new ComplexNumber(a._a, -1 * a._b);
        }

        public override bool Equals(object obj)
        {
            if ((obj as ComplexNumber)==null)
            {
                throw new ArgumentException($"Некорректный тип переменной {nameof(obj)}");
            }

            return _a == ((ComplexNumber)obj)._a && _b == ((ComplexNumber)obj)._b;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_a, _b);
        }

        public double AbsoluteValue
        {
            get { return Math.Sqrt(Math.Pow(_a, 2)+Math.Pow(_b, 2)); }
        }

        public override string ToString()
        {
            return $"{_a}{(_b > 0 ? "+" : "")}{_b}i";
        }

    }
}

