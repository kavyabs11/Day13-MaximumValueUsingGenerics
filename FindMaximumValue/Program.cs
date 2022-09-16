namespace FindMaximumValue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Generics program to find the maximum of three values");
            Find check1 = new Find();
            Find check2 = new Find();
            Find check3 = new Find();
            check1.ToCompare(3, 2, 1);
            check2.ToCompare(1.234, 2.463, 1.534);
            check3.ToCompare("Sourava", "Srivatsan", "srinivasan");
        }
    }
}