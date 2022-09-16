using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumValue
{
    public class Find<T> where T : IComparable //class type generics
    {
        public T a, b, c;
        public Find(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static T ToCompare(T a, T b, T c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 ||
                a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 ||
                a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                return a;
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 ||
                b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 ||
                b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public void Max()
        {
            T max = Find<T>.ToCompare(this.a, this.b, this.c);
            Console.WriteLine($"{max} is maximum");
        }
    }
}