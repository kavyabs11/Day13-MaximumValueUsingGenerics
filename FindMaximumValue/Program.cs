namespace FindMaximumValue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Generics program to find the maximum of three values");
            Find<int> check1 = new Find<int>(3, 2, 1);
            Find<double> check2 = new Find<double>(1.234, 1.345, 1.534);
            Find<string> check3 = new Find<string>("22", "25", "27");
            check1.Max();
            check2.Max();
            check3.Max();
        }
    }
}