namespace Card_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Card Number :");
            string cardNumber = Console.ReadLine();

            if (cardNumber == null || cardNumber.Length < 16)
            {
                Console.WriteLine("Enter the valid Number");
                return;
            }

            char[] charArray = cardNumber.ToCharArray();
            Array.Reverse(charArray);
            string reversedCardNumber = new string(charArray);

            int totalSum = 0;

            for (int i = 0; i < reversedCardNumber.Length; i++)
            {
                int digit = reversedCardNumber[i] - '0';
                if (i % 2 == 1)
                {
                    digit *= 2;
                    while (digit > 10)
                    {
                        digit -= 9;
                    }
                    totalSum += digit;
                }
                else
                {
                    totalSum += digit;
                }
            }

            if (totalSum % 10 == 0)
            {
                Console.WriteLine("Yes...The Given Number is Valid");
            }
            else
            {
                Console.WriteLine("Oops...Not a valid number");
            }
        }


    }
}
