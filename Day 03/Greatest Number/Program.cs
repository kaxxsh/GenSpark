namespace Greatest_Number
{
    internal class Program
    {
        static int GetNumber()
        {
            Console.WriteLine("Enter a number (enter a negative number to stop):");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static void Main(string[] args)
        {
            int currentNumber;
            int greatestNumber = int.MinValue;

            do
            {
                currentNumber = GetNumber();

                if (currentNumber >= 0 && currentNumber > greatestNumber)
                {
                    greatestNumber = currentNumber;
                }

            } while (currentNumber >= 0);

            if (greatestNumber != int.MinValue)
            {
                Console.WriteLine($"The greatest number entered is: {greatestNumber}");
            }
        }
    }
}
