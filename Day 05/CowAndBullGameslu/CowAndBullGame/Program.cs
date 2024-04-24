namespace CowAndBullGame
{
    internal class Program
    {
        /// <summary>
        /// verifying that who won the game
        /// </summary>
        /// <param name="code">code is the key to win need to find the code</param>
        /// <param name="word">getting from the user</param>
        /// <returns></returns>
        static bool Verify(string word)
        {
            string code = "golf";
            int COW = 0, BULL = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (code[i] == word[i])
                {
                    COW++;
                }
                for (int j = 0; j < word.Length; j++)
                {
                    
                    if (code[i] == word[j] && !(code[i] == word[i]))
                    {
                        BULL++;
                    }
                }
            }
            Console.WriteLine("COW = {0} , BULL ={1}", COW,BULL);

            if (COW == 4)
            {
                Console.WriteLine("COW WINS");
                return true;
            }
            else if (BULL == 4)
            {
                Console.WriteLine("BULL WINS");
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool check = false;
            while (!check) {
                Console.WriteLine("Enter the Word :");
                string Word = Console.ReadLine();
                check =Verify(Word);
            }
        }
    }
}
