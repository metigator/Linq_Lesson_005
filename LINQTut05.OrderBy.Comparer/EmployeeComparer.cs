using LINQTut05.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTut05.OrderBy.Comparer
{
    internal class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            // "2017-FI-1343" => "2017", "FI", "1343"
            var e1Year = Convert.ToInt32(e1.EmployeeNo.Split("-")[0]);
            var e2Year = Convert.ToInt32(e2.EmployeeNo.Split("-")[0]);
            var e1Seq= Convert.ToInt32(e1.EmployeeNo.Split("-")[2]);
            var e2Seq= Convert.ToInt32(e2.EmployeeNo.Split("-")[2]);

            if(e1Year == e2Year)
            {
                return e1Seq.CompareTo(e2Seq);  
            }
            else
            {
                return e1Year.CompareTo(e2Year);
            }

        }
    }
}
