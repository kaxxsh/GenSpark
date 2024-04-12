namespace Basic_Arithmetic
{
    internal class Program
    {
        static int Add(int a, int b) { return a + b; }
        static int Sub(int a, int b) { return b - a; }
        static int Mul(int a, int b) { return a * b; }
        static int Div(int a, int b) { return a / b; }
        static int Getnumber()
        {
            int num;
            Console.WriteLine("Please enter the the number");
            while (int.TryParse(Console.ReadLine(), out num) == false)
                Console.WriteLine("Invalid entry. Please enter a number");
            return num;
        }
        static void Operations()
        {
            int num1 = Getnumber();
            int num2 = Getnumber();
            Console.WriteLine($"Addition of {num1} and {num2} is {Add(num1, num2)}");
            Console.WriteLine($"Subtraction of {num1} and {num2} is {Sub(num1, num2)}");
            Console.WriteLine($"Multiplication of {num1} and {num2} is {Mul(num1, num2)}");
            Console.WriteLine($"Division of {num1} and {num2} is {Div(num1, num2)}");

        }
        static void Main(string[] args)
        {
            Operations();

        }
    }
}
