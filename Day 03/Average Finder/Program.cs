using System;

namespace Average_Finder
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
            int sum = 0;
            int count = 0;

            do
            {
                currentNumber = GetNumber();

                if (currentNumber >= 0 && currentNumber % 7 == 0)
                {
                    sum += currentNumber;
                    count++;
                }

            } while (currentNumber >= 0);

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine($"Average of numbers divisible by 7 entered is: {average}");
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
