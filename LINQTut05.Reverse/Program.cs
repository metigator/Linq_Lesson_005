using LINQTut05.Shared;
using System;
using System.Linq;

namespace LINQTut05.Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };

              var reveredOrder = fruits.Reverse();

            // fruits.Reverse(); // do nothing
            fruits.Print("Employees in reverse order");

            Console.ReadKey();
        }
    }
}
