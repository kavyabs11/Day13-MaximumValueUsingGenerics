namespace FindMaximumValue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 4, 3, 2, 1 };
            double[] doubleArray = { 1.765, 1.234, 1.345, 1.534 };
            string[] stringArray = { "22", "25", "27", "29" };
            Find<int> check1 = new Find<int>(intArray);
            Find<double> check2 = new Find<double>(doubleArray);
            Find<string> check3 = new Find<string>(stringArray);
            check1.Max();
            check2.Max();
            check3.Max();
        }
    }
}