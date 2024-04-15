namespace ThreeReapting
{
    internal class Program
    {

        static void ReaptingNumber()
        {
            int[] arr = { 111, 123, 444, 543, 555 };
            for (int i = 0; i < arr.Length; i++)
            {
                int one = arr[i] % 10;
                int two = (arr[i] / 10) % 10;
                int three = ((arr[i] / 10) / 10) % 10;
                if (one == two && two == three)
                {
                    Console.WriteLine("Reapting Number in an array {0} ", arr[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            ReaptingNumber();
        }
    }
}
