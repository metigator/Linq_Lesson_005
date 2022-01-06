using LINQTut05.Shared;
using System;
using System.Linq;

namespace LINQTut05.ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();
            var sortedEmps01 = emps.OrderBy(x => x.Name).ThenBy(x => x.Salary);
           
            sortedEmps01.Print("sortedEmps01");
            var sortedEmps02 = emps.OrderBy(x => x.Name).ThenByDescending(x => x.Salary);
            sortedEmps02.Print("sortedEmps02");
            Console.ReadKey();
        }
    }
}
