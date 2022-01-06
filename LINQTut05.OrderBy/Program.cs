using LINQTut05.Shared;
using System;
using System.Linq;
namespace LINQTut05.OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = 
                { "apricot", "orange", "banana", "mango", 
                "apple", "grape", "strawberry" };

            var orderedFruits = fruits.OrderBy(f => f); // ASC
            orderedFruits.Print("Fruites Asc (Method Syntax)");

            var orderedFruitsQ = from f in fruits
                                 orderby f ascending
                                 select f; 
            orderedFruitsQ.Print("Fruites Asc (Query Syntax)");

            var orderedFruitsDesc = fruits.OrderByDescending(f => f); // DESC
            orderedFruitsDesc.Print("Fruites DESC (Method Syntax)");


            var orderedFruitsDescQ = from f in fruits
                                 orderby f descending
                                 select f;
            orderedFruitsDescQ.Print("Fruites DESC (Query Syntax)");


            var orderedFruitsAscLength = fruits.OrderBy(f => f.Length); // DESC
            orderedFruitsAscLength.Print("Fruites ASC Length (Method Syntax)");

            var orderedFruitsAscLengthQ = from f in fruits
                                 orderby f.Length descending
                                 select f;
            orderedFruitsAscLengthQ.Print("Fruites DESC Length (Query Syntax)");
            Console.ReadKey();
        }
    }
}
