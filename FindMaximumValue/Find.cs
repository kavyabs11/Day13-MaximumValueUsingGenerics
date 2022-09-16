using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumValue
{
    public class Find
    {
        public void ToCompare(string a, string b, string c)
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