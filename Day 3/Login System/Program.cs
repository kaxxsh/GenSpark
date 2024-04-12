namespace Login_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxAttempt = 3;
            int count = 0;
            bool flag = true;

            while (flag && (count < maxAttempt))
            {
                Console.WriteLine("Enter the Username");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter the Password");
                string password = Console.ReadLine();

                if (userName == "ABC" && password == "123")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid username or password. Please try again.");
                    count++;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("You have exceeded the maximum number of attempts. Please try again later.");
            }
        }
    }
}
