using ShoppingApplicationModelLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication
{
    internal class LINQ
    {
        public delegate T calcDel<T>(T n1, T n2);//creating a type that refferes to a method

        void Calculate(Func<int, int, int> cal)
        {
            int n1 = 20, n2 = 10;
            int result = cal(n1, n2);
            Console.WriteLine($"The result of {n1} and {n2} is {result}");
        }
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int Sub(int num1, int num2)
        {
            return (num1 - num2);
        }
        

        public static void UnderstandingLINQ()
        {
            IList<Customer> customerList = new List<Customer>() {
                new Customer() { Id = 1, Name = "RAJ", Age = 18} ,
                new Customer() { Id = 2, Name = "EMILIA",  Age =  19} ,
                new Customer() { Id = 3, Name = "MARTHA",  Age = 18 } ,
                new Customer() { Id = 4, Name = "ADAM" , Age = 25} ,
                new Customer() { Id = 5, Name = "EVE" , Age = 19 },
                new Customer() { Id = 6, Name = "KATHERINE" , Age = 19 }
            };


        }
    }

    public class customSeperator : IEqualityComparer<Customer>
    {

        public bool Equals(Customer? x, Customer? y)
        {
            return (x.Id == y.Id && x.Name == y.Name);
        }

        public int GetHashCode([DisallowNull] Customer obj)
        {
            return obj.GetHashCode();
        }
    }




    public static class StringMethods
    {
        public static string Reverse(this string msg)
        {
            char[] chars = msg.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

    }
    public static class NumberExtension
    {
        public static int[] EvenCatch(this int[] nums)
        {
            List<int> result = new List<int>();
            foreach (int num in nums)
                if (num % 2 == 0)
                    result.Add(num);
            return result.ToArray();
        }
    }
}
