
using System;
using System.Collections.Generic; 

namespace LINQTut05.Shared
{
    public static class Repository
    {

        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee> 
            {
                    new Employee
                    {
                         EmployeeNo = "2017-FI-1343",
                         Name = "Cochran Cole",
                         Email = "Cole.Cochran01@example.com",
                         Salary = 1032,
                         Skills = new() {"Javascript" , "C++" , "NodeJS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-FI-1755",
                         Name = "Jaclyn Wolfe",
                         Email = "Wolfe.Jaclyn@example.com",
                         Salary = 1924,
                         Skills = new() {"C#" , "Javascript" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-IT-1441",
                         Name = "Cochran Cole",
                         Email = "Cole.Cochran02@example.com",
                         Salary = 1728,
                         Skills = new() {"ASP.NET" , "Javascript"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-FI-3447",
                         Name = "Hester Evans",
                         Email = "Evans.Hester@example.com",
                         Salary = 1555,
                         Skills = new() {"CSS" , "Javascript" , "NodeJS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-IT-2956",
                         Name = "Wallace Buck",
                         Email = "Buck.Wallace@example.com",
                         Salary = 3158,
                         Skills = new() {"Oracle" , "HTML" , "CSS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-IT-6341",
                         Name = "Acevedo Wall",
                         Email = "Wall.Acevedo@example.com",
                         Salary = 3437,
                         Skills = new() {"ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-IT-4488",
                         Name = "Jacqueline Pickett",
                         Email = "Pickett.Jacqueline@example.com",
                         Salary = 3700,
                         Skills = new() {"NodeJS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-HR-3248",
                         Name = "Oconnor Espinoza",
                         Email = "Espinoza.Oconnor@example.com",
                         Salary = 1556,
                         Skills = new() {"SQL Server" , "C#" , "HTML" , "C++"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-AC-9097",
                         Name = "Allie Elliott",
                         Email = "Elliott.Allie@example.com",
                         Salary = 3154,
                         Skills = new() {"Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-HR-3770",
                         Name = "Elva Decker",
                         Email = "Decker.Elva@example.com",
                         Salary = 3459,
                         Skills = new() {"ASP.NET" , "Javascript" , "C#"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-HR-8809",
                         Name = "Hayes Beasley",
                         Email = "Beasley.Hayes@example.com",
                         Salary = 3727,
                         Skills = new() {"SQL Server" , "C++" , "NodeJS" , "Oracle" , "Javascript"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2015-FI-3038",
                         Name = "Florine Cervantes",
                         Email = "Cervantes.Florine@example.com",
                         Salary = 3387,
                         Skills = new() {"HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-AC-7409",
                         Name = "Bullock Carney",
                         Email = "Carney.Bullock@example.com",
                         Salary = 2144,
                         Skills = new() {"C++" , "CSS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-FI-3725",
                         Name = "Carroll Cantu",
                         Email = "Cantu.Carroll@example.com",
                         Salary = 3432,
                         Skills = new() {"C++" , "C#"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-IT-9738",
                         Name = "Debra Hogan",
                         Email = "Hogan.Debra@example.com",
                         Salary = 2491,
                         Skills = new() {"Oracle" , "NodeJS" , "HTML" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-IT-7184",
                         Name = "Winnie Mccall",
                         Email = "Mccall.Winnie@example.com",
                         Salary = 2873,
                         Skills = new() {"CSS" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2015-IT-4664",
                         Name = "Manuela Berger",
                         Email = "Berger.Manuela@example.com",
                         Salary = 1725,
                         Skills = new() {"Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-IT-3609",
                         Name = "Lakeisha Lowe",
                         Email = "Lowe.Lakeisha@example.com",
                         Salary = 3143,
                         Skills = new() {"NodeJS" , "Oracle" , "CSS" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-FI-2682",
                         Name = "Stewart Lott",
                         Email = "Lott.Stewart@example.com",
                         Salary = 1466,
                         Skills = new() {"ASP.NET" , "C#" , "Javascript" , "SQL Server" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-IT-3754",
                         Name = "Stafford Peck",
                         Email = "Peck.Stafford@example.com",
                         Salary = 3207,
                         Skills = new() {"C++" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-HR-7462",
                         Name = "Barron Bird",
                         Email = "Bird.Barron@example.com",
                         Salary = 1512,
                         Skills = new() {"NodeJS" , "Javascript" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2015-IT-5171",
                         Name = "Nona Brooks",
                         Email = "Brooks.Nona@example.com",
                         Salary = 1365,
                         Skills = new() {"HTML" , "NodeJS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-IT-6267",
                         Name = "Clara Reeves",
                         Email = "Reeves.Clara@example.com",
                         Salary = 2458,
                         Skills = new() {"ASP.NET" , "NodeJS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-IT-8208",
                         Name = "Karin Blanchard",
                         Email = "Blanchard.Karin@example.com",
                         Salary = 3412,
                         Skills = new() {"C#" , "SQL Server" , "NodeJS" , "CSS" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-AC-8905",
                         Name = "Burris Morgan",
                         Email = "Morgan.Burris@example.com",
                         Salary = 3603,
                         Skills = new() {"C++" , "CSS" , "ASP.NET" , "Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-IT-7496",
                         Name = "Owen Cortez",
                         Email = "Cortez.Owen@example.com",
                         Salary = 1937,
                         Skills = new() {"Oracle" , "Javascript" , "C++" , "NodeJS" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-AC-4762",
                         Name = "Letha Finch",
                         Email = "Finch.Letha@example.com",
                         Salary = 3572,
                         Skills = new() {"Oracle" , "CSS" , "NodeJS" , "C#" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-AC-2518",
                         Name = "Sondra Rojas",
                         Email = "Rojas.Sondra@example.com",
                         Salary = 3097,
                         Skills = new() {"Javascript" , "SQL Server"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-HR-9123",
                         Name = "Hoover Cook",
                         Email = "Cook.Hoover@example.com",
                         Salary = 2822,
                         Skills = new() {"Oracle" , "ASP.NET" , "Javascript" , "CSS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-AC-5938",
                         Name = "Wanda Bender",
                         Email = "Bender.Wanda@example.com",
                         Salary = 2942,
                         Skills = new() {"SQL Server" , "Javascript" , "NodeJS" , "C#" , "CSS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-AC-6792",
                         Name = "Sanford Craig",
                         Email = "Craig.Sanford@example.com",
                         Salary = 2782,
                         Skills = new() {"NodeJS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-FI-7673",
                         Name = "Christy Middleton",
                         Email = "Middleton.Christy@example.com",
                         Salary = 3774,
                         Skills = new() {"CSS" , "C#"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-HR-7369",
                         Name = "Day Brady",
                         Email = "Brady.Day@example.com",
                         Salary = 1426,
                         Skills = new() {"SQL Server" , "Oracle" , "C++" , "CSS" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-FI-2740",
                         Name = "Powers Beard",
                         Email = "Beard.Powers@example.com",
                         Salary = 2240,
                         Skills = new() {"NodeJS" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-FI-6079",
                         Name = "Arline Pratt",
                         Email = "Pratt.Arline@example.com",
                         Salary = 3603,
                         Skills = new() {"Javascript" , "Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-AC-5189",
                         Name = "Sharpe Cardenas",
                         Email = "Cardenas.Sharpe@example.com",
                         Salary = 2661,
                         Skills = new() {"HTML" , "SQL Server" , "ASP.NET" , "Oracle" , "C++"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-AC-6920",
                         Name = "Madeleine Stanton",
                         Email = "Stanton.Madeleine@example.com",
                         Salary = 1983,
                         Skills = new() {"C#"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-FI-8160",
                         Name = "Spears Noble",
                         Email = "Noble.Spears@example.com",
                         Salary = 1763,
                         Skills = new() {"C#" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-IT-7542",
                         Name = "Gonzalez Gilliam",
                         Email = "Gilliam.Gonzalez@example.com",
                         Salary = 3943,
                         Skills = new() {"Oracle" , "CSS" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-FI-1312",
                         Name = "Abigail Bradford",
                         Email = "Bradford.Abigail@example.com",
                         Salary = 2961,
                         Skills = new() {"C#" , "ASP.NET" , "HTML" , "NodeJS" , "CSS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-IT-4198",
                         Name = "Ashlee Farmer",
                         Email = "Farmer.Ashlee@example.com",
                         Salary = 1253,
                         Skills = new() {"Javascript" , "C++" , "SQL Server"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-IT-7772",
                         Name = "Glover Lloyd",
                         Email = "Lloyd.Glover@example.com",
                         Salary = 1230,
                         Skills = new() {"Oracle" , "CSS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-IT-4562",
                         Name = "Cleo Mays",
                         Email = "Mays.Cleo@example.com",
                         Salary = 2149,
                         Skills = new() {"SQL Server" , "NodeJS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-IT-4227",
                         Name = "Patrice House",
                         Email = "House.Patrice@example.com",
                         Salary = 1245,
                         Skills = new() {"Javascript" , "CSS" , "Oracle" , "C#"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2015-AC-6366",
                         Name = "Atkins Shannon",
                         Email = "Shannon.Atkins@example.com",
                         Salary = 1366,
                         Skills = new() {"Oracle" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-AC-1212",
                         Name = "Luisa Hopkins",
                         Email = "Hopkins.Luisa@example.com",
                         Salary = 1929,
                         Skills = new() {"C++" , "ASP.NET" , "Javascript" , "Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-IT-4794",
                         Name = "Kaufman Gross",
                         Email = "Gross.Kaufman@example.com",
                         Salary = 2236,
                         Skills = new() {"ASP.NET" , "HTML" , "C#" , "CSS" , "SQL Server"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-HR-4395",
                         Name = "William Clay",
                         Email = "Clay.William@example.com",
                         Salary = 2375,
                         Skills = new() {"Javascript"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-IT-1387",
                         Name = "Alison Kirby",
                         Email = "Kirby.Alison@example.com",
                         Salary = 3548,
                         Skills = new() {"Javascript"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-AC-7846",
                         Name = "Morrow Lynch",
                         Email = "Lynch.Morrow@example.com",
                         Salary = 2814,
                         Skills = new() {"ASP.NET" , "C#"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-IT-3225",
                         Name = "Roach Bright",
                         Email = "Bright.Roach@example.com",
                         Salary = 3267,
                         Skills = new() {"Javascript" , "SQL Server" , "NodeJS" , "ASP.NET" , "C#"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-FI-6985",
                         Name = "Carolyn Justice",
                         Email = "Justice.Carolyn@example.com",
                         Salary = 1431,
                         Skills = new() {"HTML" , "C++" , "ASP.NET" , "Javascript" , "Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-FI-6331",
                         Name = "Cathryn Mathews",
                         Email = "Mathews.Cathryn@example.com",
                         Salary = 3660,
                         Skills = new() {"C++"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-AC-2870",
                         Name = "Lindsay Pruitt",
                         Email = "Pruitt.Lindsay@example.com",
                         Salary = 1073,
                         Skills = new() {"C#" , "NodeJS" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-AC-9730",
                         Name = "Cummings Webster",
                         Email = "Webster.Cummings@example.com",
                         Salary = 2227,
                         Skills = new() {"Oracle" , "NodeJS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-AC-5421",
                         Name = "Cannon Pace",
                         Email = "Pace.Cannon@example.com",
                         Salary = 3450,
                         Skills = new() {"HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-AC-1564",
                         Name = "Barber Singleton",
                         Email = "Singleton.Barber@example.com",
                         Salary = 1924,
                         Skills = new() {"Javascript"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-AC-8647",
                         Name = "Aileen Sweet",
                         Email = "Sweet.Aileen@example.com",
                         Salary = 2624,
                         Skills = new() {"CSS" , "Javascript" , "C++"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-FI-1877",
                         Name = "Lindsey Hughes",
                         Email = "Hughes.Lindsey@example.com",
                         Salary = 3700,
                         Skills = new() {"SQL Server" , "C++" , "CSS" , "C#" , "Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-FI-5494",
                         Name = "Stout Phillips",
                         Email = "Phillips.Stout@example.com",
                         Salary = 1510,
                         Skills = new() {"Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-AC-4682",
                         Name = "Benjamin Stephens",
                         Email = "Stephens.Benjamin@example.com",
                         Salary = 3996,
                         Skills = new() {"C#" , "NodeJS" , "CSS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-AC-8818",
                         Name = "Mandy Odom",
                         Email = "Odom.Mandy@example.com",
                         Salary = 2264,
                         Skills = new() {"SQL Server"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-AC-8946",
                         Name = "Hays Austin",
                         Email = "Austin.Hays@example.com",
                         Salary = 2920,
                         Skills = new() {"C#" , "Oracle" , "C++" , "CSS" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-HR-2271",
                         Name = "Jean Salas",
                         Email = "Salas.Jean@example.com",
                         Salary = 2116,
                         Skills = new() {"HTML" , "SQL Server" , "Javascript" , "Oracle" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-HR-3289",
                         Name = "Luann Hubbard",
                         Email = "Hubbard.Luann@example.com",
                         Salary = 3016,
                         Skills = new() {"Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-IT-2893",
                         Name = "Eaton Lyons",
                         Email = "Lyons.Eaton@example.com",
                         Salary = 2376,
                         Skills = new() {"C#" , "CSS" , "Javascript" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2015-HR-7939",
                         Name = "Beck Ortiz",
                         Email = "Ortiz.Beck@example.com",
                         Salary = 1929,
                         Skills = new() {"CSS" , "C#" , "SQL Server" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-IT-8169",
                         Name = "Patty Knight",
                         Email = "Knight.Patty@example.com",
                         Salary = 1731,
                         Skills = new() {"NodeJS" , "SQL Server" , "Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-IT-8048",
                         Name = "Bowman Hampton",
                         Email = "Hampton.Bowman@example.com",
                         Salary = 1452,
                         Skills = new() {"Oracle" , "ASP.NET" , "C#"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-HR-9151",
                         Name = "Pace Bryant",
                         Email = "Bryant.Pace@example.com",
                         Salary = 1601,
                         Skills = new() {"CSS" , "Javascript" , "NodeJS" , "Oracle" , "SQL Server"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-FI-1631",
                         Name = "Watts Green",
                         Email = "Green.Watts@example.com",
                         Salary = 3303,
                         Skills = new() {"ASP.NET" , "Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-AC-4574",
                         Name = "Sonia Clarke",
                         Email = "Clarke.Sonia@example.com",
                         Salary = 2018,
                         Skills = new() {"C#" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-FI-2678",
                         Name = "Donovan Brennan",
                         Email = "Brennan.Donovan@example.com",
                         Salary = 2436,
                         Skills = new() {"SQL Server" , "Javascript" , "C#" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-IT-7173",
                         Name = "Rutledge Harris",
                         Email = "Harris.Rutledge@example.com",
                         Salary = 1533,
                         Skills = new() {"CSS" , "C#" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-FI-3360",
                         Name = "Buckley Meyers",
                         Email = "Meyers.Buckley@example.com",
                         Salary = 3420,
                         Skills = new() {"C#" , "HTML" , "Oracle" , "Javascript"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-AC-6780",
                         Name = "Reynolds Hammond",
                         Email = "Hammond.Reynolds@example.com",
                         Salary = 2326,
                         Skills = new() {"Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-HR-2514",
                         Name = "Butler Bowen",
                         Email = "Bowen.Butler@example.com",
                         Salary = 2391,
                         Skills = new() {"C++" , "SQL Server" , "Oracle" , "C#" , "NodeJS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-IT-8910",
                         Name = "Karina Miles",
                         Email = "Miles.Karina@example.com",
                         Salary = 1855,
                         Skills = new() {"CSS" , "NodeJS" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-AC-3932",
                         Name = "Fulton Conner",
                         Email = "Conner.Fulton@example.com",
                         Salary = 1981,
                         Skills = new() {"CSS" , "ASP.NET" , "Oracle" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-HR-1973",
                         Name = "Jewell Tran",
                         Email = "Tran.Jewell@example.com",
                         Salary = 2648,
                         Skills = new() {"ASP.NET" , "HTML" , "C++" , "Javascript"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-AC-3751",
                         Name = "Avis Herrera",
                         Email = "Herrera.Avis@example.com",
                         Salary = 2988,
                         Skills = new() {"C#" , "ASP.NET" , "Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-IT-4849",
                         Name = "Nora Dale",
                         Email = "Dale.Nora@example.com",
                         Salary = 3689,
                         Skills = new() {"SQL Server" , "ASP.NET" , "Javascript"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-AC-9189",
                         Name = "Hillary Duran",
                         Email = "Duran.Hillary@example.com",
                         Salary = 2822,
                         Skills = new() {"CSS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-HR-9193",
                         Name = "Hamilton Macias",
                         Email = "Macias.Hamilton@example.com",
                         Salary = 2373,
                         Skills = new() {"C#" , "Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-HR-8262",
                         Name = "Kent Parsons",
                         Email = "Parsons.Kent@example.com",
                         Salary = 1764,
                         Skills = new() {"C#"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-AC-6998",
                         Name = "Dunn Oliver",
                         Email = "Oliver.Dunn@example.com",
                         Salary = 2444,
                         Skills = new() {"C++" , "C#" , "NodeJS" , "Javascript" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2018-IT-7524",
                         Name = "Betsy Dean",
                         Email = "Dean.Betsy@example.com",
                         Salary = 1969,
                         Skills = new() {"HTML" , "SQL Server" , "Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-AC-1313",
                         Name = "Kay May",
                         Email = "May.Kay@example.com",
                         Salary = 2240,
                         Skills = new() {"HTML" , "Javascript" , "C#" , "CSS" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-IT-9981",
                         Name = "Farley Bartlett",
                         Email = "Bartlett.Farley@example.com",
                         Salary = 3696,
                         Skills = new() {"CSS"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-IT-9816",
                         Name = "Agnes Riggs",
                         Email = "Riggs.Agnes@example.com",
                         Salary = 1068,
                         Skills = new() {"SQL Server"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-HR-4458",
                         Name = "White Figueroa",
                         Email = "Figueroa.White@example.com",
                         Salary = 2264,
                         Skills = new() {"Oracle" , "ASP.NET" , "C#"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-HR-8991",
                         Name = "Estes Stone",
                         Email = "Stone.Estes@example.com",
                         Salary = 2938,
                         Skills = new() {"Javascript" , "C++" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-FI-4888",
                         Name = "Julia Contreras",
                         Email = "Contreras.Julia@example.com",
                         Salary = 2038,
                         Skills = new() {"C++" , "CSS" , "NodeJS" , "Javascript"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2017-FI-8639",
                         Name = "Cecilia Cooper",
                         Email = "Cooper.Cecilia@example.com",
                         Salary = 3294,
                         Skills = new() {"SQL Server" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2015-AC-2109",
                         Name = "Zelma Frank",
                         Email = "Frank.Zelma@example.com",
                         Salary = 3111,
                         Skills = new() {"Oracle"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2021-FI-4677",
                         Name = "Peters Morales",
                         Email = "Morales.Peters@example.com",
                         Salary = 1203,
                         Skills = new() {"C#" , "NodeJS" , "SQL Server" , "ASP.NET" , "C++"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2016-FI-1198",
                         Name = "Leigh Moss",
                         Email = "Moss.Leigh@example.com",
                         Salary = 1671,
                         Skills = new() {"Oracle" , "Javascript" , "C#" , "SQL Server" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2014-FI-5416",
                         Name = "Megan Bailey",
                         Email = "Bailey.Megan@example.com",
                         Salary = 2325,
                         Skills = new() {"CSS" , "ASP.NET" , "HTML"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2020-FI-1804",
                         Name = "Juliana Pope",
                         Email = "Pope.Juliana@example.com",
                         Salary = 3053,
                         Skills = new() {"C#" , "SQL Server"  }
                    },
                    new Employee
                    {
                         EmployeeNo = "2019-IT-1162",
                         Name = "Cervantes Wong",
                         Email = "Wong.Cervantes@example.com",
                         Salary = 2351,
                         Skills = new() {"CSS" , "HTML" , "ASP.NET" , "NodeJS" , "Javascript"  }
                    }
            };
        } 
    }
}
