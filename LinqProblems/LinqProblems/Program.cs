using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var(num1LinqBegin1, num2LinqBegin1) = LinqBegin1();
            Console.WriteLine($"{num1LinqBegin1}, {num2LinqBegin1}");
            var numLinqBegin2 = LinqBegin2(2);
            Console.WriteLine(numLinqBegin2);
            var numLinqBegin3 = LinqBegin3(4);
            Console.WriteLine(numLinqBegin3);
            var numLinqBegin4 = LinqBegin4('s');
            Console.WriteLine(numLinqBegin4);
            var numLinqBegin5 = LinqBegin5('q');
            Console.WriteLine(numLinqBegin5);
            var numLinqBegin6 = LinqBegin6();
            Console.WriteLine(numLinqBegin6);
            var (num1LinqBegin7, num2LinqBegin7) = LinqBegin7();
            Console.WriteLine($"{num1LinqBegin7}, {num2LinqBegin7}");
            var (num1LinqBegin8, num2LinqBegin8) = LinqBegin8();
            Console.WriteLine($"{num1LinqBegin8}, {num2LinqBegin8}");
            var numLinqBegin9 = LinqBegin9();
            Console.WriteLine(numLinqBegin9);
            var numLinqBegin10 = LinqBegin10(4);
            Console.WriteLine(numLinqBegin10);
            var numLinqBegin13 = LinqBegin13(4);
            Console.WriteLine(numLinqBegin13);
            var numLinqBegin14 = LinqBegin14(1, 3);
            Console.WriteLine(numLinqBegin14);
            var numLinqBegin15 = LinqBegin15(5);
            Console.WriteLine(numLinqBegin15);


            Console.ReadKey();
        }
        static (int num1, int num2) LinqBegin1()
        {
            List<int> list = new List<int>()
            {
                -1,
                -5,
                2,
                -4,
                5
            };
            var num1 = list.Where(x => x > 0).First();
            //var num2 = list.Where(x => x < 0).Reverse().First();
            var num2 = list.Where(x => x < 0).Last();
            return (num1, num2);
        }
        static int LinqBegin2(int D)
        {
            List<int> A = new List<int>()
            {
                -1,
                -5,
                22,
                -4,
                52
            };
            var num = A.Where(x => x > 0).Where(x => { if (Convert.ToString(x)[Convert.ToString(x).Length - 1] == Convert.ToString(D)[0]) { return true; } else { return false; } }).FirstOrDefault();
            return num;
        }
        static string LinqBegin3(int L)
        {
            List<string> A = new List<string>()
            {
                "f1eqe",
                "21eqwe",
                "qfwrge",
                "3rwrsdf"
            };
            var num = A.Where(x => x[0] <= '9' && x[0] >= '0' && x.Count() == L).Reverse().Append("Not found").First();
            return num;
        }
        static string LinqBegin4(char C)
        {
            List<string> A = new List<string>()
            {
                "f1eqe",
                "21eqwe",
                "qfwrge",
                "3rwrsdf"
            };
            string num;
            try
            {
                num = A.SingleOrDefault(x => x[x.Length - 1] == C);
            }
            catch (InvalidOperationException)
            {
                return "Error";
            }
            return num;
        }
        static int LinqBegin5(char C)
        {
            List<string> A = new List<string>()
            {
                "f1eqe",
                "q21eqweq",
                "qfwrgeq",
                "3rwrsdf"
            };
            int num = A.Where(x => x.Length > 1 && x[x.Length - 1] == C && x[0] == C ? true : false).Count();
            return num;
        }
        static int LinqBegin6()
        {
            List<string> A = new List<string>()
            {
                "f1eqe",
                "q21eqweq",
                "qfwrgeq",
                "3rwrsdf"
            };
            var num = A.Select(x => x.Length).Sum();
            return num;
        }
        static (int num1, int num2) LinqBegin7()
        {
            List<int> A = new List<int>()
            {
                -1,
                -5,
                53,
                3,
                -4
            };
            int num1, num2;
            try
            {
                num1 = A.Where(x => x < 0).Count();
                num2 = A.Where(x => x < 0).Sum();
            }
            catch (InvalidOperationException)
            {
                return (0, 0);
            }
            return (num1, num2);
        }
        static (int num1, double num2) LinqBegin8()
        {
            List<int> A = new List<int>()
            {
                -1,
                -5,
                53,
                3,
                -4,
                100,
                84,
                81
            };
            int num1;
            double num2;
            try
            {
                num1 = A.Where(x => x > 9 && x < 100).Count();
                var num3 = A.Where(x => x > 9 && x < 100).Sum();
                num2 = (double)num3 / (double)num1;
            }
            catch (InvalidOperationException)
            {
                return (0, 0);
            }
            return (num1, num2);
        }
        static int LinqBegin9()
        {
            List<int> A = new List<int>()
            {
                -1,
                -5,
                53,
                3,
                -4,
                100,
                84,
                81
            };
            int num1;
            try
            {
                num1 = A.Where(x => x > 0).Min();
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
            return num1;
        }
        static string LinqBegin10(int L)
        {
            List<string> A = new List<string>()
            {
                "B1eq",
                "Cfwr",
                "drwr",
                "A1eq"
            };
            string num;
            try
            {
                num = A.Where(x => x.Length == L && x[0] > 'A' && x[0] < 'Z').OrderByDescending(x => x).First();
            }
            catch (InvalidOperationException)
            {
                return "";
            }
            return num;
        }
        //static string LinqBegin11()
        //{
        //    List<string> A = new List<string>()
        //    {
        //        "B1eq",
        //        "Cfwr",
        //        "drwr",
        //        "A1eq"
        //    };
        //    string num;
        //    int i = 0;
        //    try
        //    {
        //        num = A.Aggregate((x,y) => y);
        //    }
        //    catch (InvalidOperationException)
        //    {
        //        return "";
        //    }
        //    return num;
        //}
        static double LinqBegin13(int N)
        {
            var num2 = Enumerable.Range(1, N).Sum(x => 1/(double)x);
            return num2;
        }
        static double LinqBegin14(int A, int B)
        {
            var num2 = Enumerable.Range(A, B).Average(x => x*x);
            return num2;
        }
        static double LinqBegin15(int N)
        {
            double num2;
            try
            {
                num2 = Enumerable.Range(1, N).Aggregate((x, y) => N == 0 ? y = 1 : x * y);
            }
            catch (InvalidOperationException)
            {
                return 1;
            }
            return num2;
        }
    }
}
