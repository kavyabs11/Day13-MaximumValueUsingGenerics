using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumValue
{
    internal class Find
    {
        public void ToCompare<T>(T a, T b, T c) where T : IComparable //Generic method
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 ||
                a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 ||
                a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                Console.WriteLine($"{a} is Maximum");
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 ||
                b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 ||
                b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                Console.WriteLine($"{b} is Maximum");
            }
            else
            {
                Console.WriteLine($"{c} is Maximum");
            }
        }
    }
    }

