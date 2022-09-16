namespace FindMaximumValue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Generics program to find the maximum of three values");
            Find check = new Find();
            check.ToCompare(3.1f, 2.2f, 1.3f);
        }
    }
}