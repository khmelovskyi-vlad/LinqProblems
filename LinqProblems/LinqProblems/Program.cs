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
            Test test = new Test();
            test.Run();
            Console.ReadKey();
            Console.WriteLine("num1");
            var (num1LinqBegin1, num2LinqBegin1) = LinqBegin1();
            Console.WriteLine($"{num1LinqBegin1}, {num2LinqBegin1}");
            Console.WriteLine("num2");
            var numLinqBegin2 = LinqBegin2(2);
            Console.WriteLine(numLinqBegin2);
            Console.WriteLine("num3");
            var numLinqBegin3 = LinqBegin3(4);
            Console.WriteLine(numLinqBegin3);
            Console.WriteLine("num4");
            var numLinqBegin4 = LinqBegin4('s');
            Console.WriteLine(numLinqBegin4);
            Console.WriteLine("num5");
            var numLinqBegin5 = LinqBegin5('q');
            Console.WriteLine(numLinqBegin5);
            Console.WriteLine("num6");
            var numLinqBegin6 = LinqBegin6();
            Console.WriteLine(numLinqBegin6);
            Console.WriteLine("num7");
            var (num1LinqBegin7, num2LinqBegin7) = LinqBegin7();
            Console.WriteLine($"{num1LinqBegin7}, {num2LinqBegin7}");
            Console.WriteLine("num8");
            var (num1LinqBegin8, num2LinqBegin8) = LinqBegin8();
            Console.WriteLine($"{num1LinqBegin8}, {num2LinqBegin8}");
            Console.WriteLine("num9");
            var numLinqBegin9 = LinqBegin9();
            Console.WriteLine(numLinqBegin9);
            Console.WriteLine("num10");
            var numLinqBegin10 = LinqBegin10(4);
            Console.WriteLine(numLinqBegin10);
            Console.WriteLine("num11");
            Console.WriteLine("num12");
            Console.WriteLine("num13");
            var numLinqBegin13 = LinqBegin13(4);
            Console.WriteLine(numLinqBegin13);
            Console.WriteLine("num14");
            var numLinqBegin14 = LinqBegin14(1, 3);
            Console.WriteLine(numLinqBegin14);
            Console.WriteLine("num15");
            var numLinqBegin15 = LinqBegin15(5);
            Console.WriteLine(numLinqBegin15);
            Console.WriteLine("num16");
            var numLinqBegin16 = LinqBegin16();
            foreach (var num in numLinqBegin16)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num17");
            var numLinqBegin17 = LinqBegin17();
            foreach (var num in numLinqBegin17)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num18");
            var numLinqBegin18 = LinqBegin18();
            foreach (var num in numLinqBegin18)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num19");
            var numLinqBegin19 = LinqBegin19(4);
            foreach (var num in numLinqBegin19)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num20");
            var numLinqBegin20 = LinqBegin20();
            foreach (var num in numLinqBegin20)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num21");
            var numLinqBegin21 = LinqBegin21();
            foreach (var num in numLinqBegin21)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num22");
            var numLinqBegin22 = LinqBegin22(5);
            foreach (var num in numLinqBegin22)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num23");
            var numLinqBegin23 = LinqBegin23(2);
            foreach (var num in numLinqBegin23)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num24");
            var numLinqBegin24 = LinqBegin24(2);
            foreach (var num in numLinqBegin24)
            {
                Console.WriteLine(num);
            }
            //Console.WriteLine("num25");
            //var numLinqBegin25 = LinqBegin25(2, 4);
            //Console.WriteLine(numLinqBegin25);
            //Console.WriteLine("num26");
            //var numLinqBegin26 = LinqBegin26(2, 4);
            //Console.WriteLine(numLinqBegin26);
            Console.WriteLine("num32");
            var numLinqBegin32 = LinqBegin32();
            foreach (var num in numLinqBegin32)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num33");
            var numLinqBegin33 = LinqBegin33();
            foreach (var num in numLinqBegin33)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num34");
            var numLinqBegin34 = LinqBegin34();
            foreach (var num in numLinqBegin34)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num35");
            var numLinqBegin35 = LinqBegin35();
            foreach (var num in numLinqBegin35)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num36");
            var numLinqBegin36 = LinqBegin36();
            foreach (var num in numLinqBegin36)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num37");
            var numLinqBegin37 = LinqBegin37();
            foreach (var num in numLinqBegin37)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num38");
            var numLinqBegin38 = LinqBegin38();
            foreach (var num in numLinqBegin38)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num39");
            var numLinqBegin39 = LinqBegin39();
            foreach (var num in numLinqBegin39)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num40");
            var numLinqBegin40 = LinqBegin40(4);
            foreach (var num in numLinqBegin40)
            {
                Console.WriteLine(num);
            }
            //Console.WriteLine("num41");
            //var numLinqBegin41 = LinqBegin41(4);
            //foreach (var num in numLinqBegin41)
            //{
            //    Console.WriteLine(num);
            //}
            Console.WriteLine("num42");
            var numLinqBegin42 = LinqBegin42();
            foreach (var num in numLinqBegin42)
            {
                Console.WriteLine(num);
            }
            //Console.WriteLine("num43");
            //var numLinqBegin43 = LinqBegin43();
            //foreach (var num in numLinqBegin43)
            //{
            //    Console.WriteLine(num);
            //}
            Console.WriteLine("num44");
            var numLinqBegin44 = LinqBegin44(4, 5);
            foreach (var num in numLinqBegin44)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num45");
            var numLinqBegin45 = LinqBegin45(4, 5);
            foreach (var num in numLinqBegin45)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num46");
            var numLinqBegin46 = LinqBegin46();
            foreach (var num in numLinqBegin46)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num47");
            var numLinqBegin47 = LinqBegin47();
            foreach (var num in numLinqBegin47)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("num48");
            var numLinqBegin48 = LinqBegin48();
            foreach (var num in numLinqBegin48)
            {
                Console.WriteLine(num);
            }





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
        //        num = A.Aggregate("", (x, y) => x[i] = y[0]);
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
        static IEnumerable<int> LinqBegin16()
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
            return A.Where(x => x > 0);
        }
        static IEnumerable<int> LinqBegin17()
        {
            List<int> A = new List<int>()
            {
                -1,
                -5,
                -5,
                53,
                3,
                -4,
                100,
                84,
                100,
                81
            };
            return A.Where(x => x % 2 != 0).Distinct();
        }
        static IEnumerable<int> LinqBegin18()
        {
            List<int> A = new List<int>()
            {
                -1,
                -5,
                -5,
                53,
                3,
                -4,
                100,
                84,
                100,
                81
            };
            return A.Where(x => x % 2 == 0 && x < 0).Reverse();
        }
        static IEnumerable<int> LinqBegin19(int D)
        {
            List<int> A = new List<int>()
            {
                -1,
                -5,
                -5,
                53,
                3,
                -4,
                100,
                84,
                100,
                81
            };
            return A.Where(x => x > 0 && x.ToString()[x.ToString().Length - 1] == D.ToString()[0]).Reverse().Distinct().Reverse();
        }
        static IEnumerable<int> LinqBegin20()
        {
            List<int> A = new List<int>()
            {
                -1,
                -5,
                -5,
                53,
                3,
                -4,
                100,
                84,
                100,
                81
            };
            return A.Where(x => x > 0 && x > 9 && x < 100).OrderBy(x => x);
        }
        static IEnumerable<string> LinqBegin21()
        {
            List<string> A = new List<string>()
            {
                "A1eqe",
                "a1eqe",
                "Cfwrgeq",
                "Bb21eqweq",
                "Afwrgeq",
                "D4rwrsdf"
            };
            return A.Where(x => x[0] >= 'A' && x[0] <= 'Z').OrderBy(x => x.Length).ThenByDescending(x => x);
        }
        static IEnumerable<string> LinqBegin22(int K)
        {
            List<string> A = new List<string>()
            {
                "1f1eqe",
                "Aq21eqweq",
                "2f1se",
                "Af1q1",
                "6qfwrgeq",
                "rwrd1"
            };
            return A.Where(x => (x[0] >= 'A' && x[0] <= 'Z' || x[0] >= '0' && x[0] <= '9') && x.Length == K && x[x.Length - 1] >= '0' && x[x.Length - 1] <= '9').OrderBy(x => x);
        }
        static IEnumerable<int> LinqBegin23(int K)
        {
            List<int> A = new List<int>()
            {
                53,
                -1,
                -5,
                -5,
                53,
                3,
                -4,
                100,
                84,
                100,
                81
            };
            return A.Skip(K).Where(x => x % 2 != 0 && x > 9 && x < 100).OrderByDescending(x => x);
        }
        static IEnumerable<string> LinqBegin24(int K)
        {
            List<string> A = new List<string>()
            {
                "A1e",
                "B1",
                "F1eq",
                "C1eqe",
                "W1eqe",
                "F1eq",
                "q21eqweq",
                "qfwrgeq",
                "3rwrsdf"
            };
            return A.Take(K).Where(x => x.Length % 2 != 0 && x[0] >= 'A' && x[0] <= 'Z').Reverse();
        }
        //static int LinqBegin25(int K1, int K2)
        //{
        //    List<int> A = new List<int>()
        //    {
        //        -1,
        //        -5,
        //        -5,
        //        53,
        //        3,
        //        -4,
        //        100,
        //        84,
        //        100,
        //        81
        //    };
        //    return A.Skip(K1 - 1).Take(K2 - K1).Where(x => A[K1] < 0 && A[K2] > A.Count()).Sum();
        //}
        //static double LinqBegin26(int K1, int K2)
        //{
        //    List<string> A = new List<string>()
        //    {
        //        "f1eqe",
        //        "q21eqweq",
        //        "Tfwrgeq",
        //        "q2as1eqweq",
        //        "Qweq21eqweq",
        //        "3rwrsdf"
        //    };
        //    return A.SkipWhile(x => A[K1].Length >= A[K2].Length).Average(x => x.Length);
        //}
        static IEnumerable<char> LinqBegin32()
        {
            List<string> A = new List<string>()
            {
                "A1e",
                "B1",
                "F1eq",
                "C1eqe",
                "W1eqe",
                "F1eq",
                "q21eqweq",
                "qfwrgeq",
                "3rwrsdf"
            };
            return A.Select(x => x[0]).Reverse();
        }
        static IEnumerable<int> LinqBegin33()
        {
            List<int> A = new List<int>()
            {
                53,
                -1,
                -5,
                -5,
                53,
                3,
                -4,
                100,
                84,
                100,
                81
            };
            return A.Where(x => x > 0).Select(x => Convert.ToInt32((x.ToString()[x.ToString().Length - 1].ToString()))).Distinct();
        }
        static IEnumerable<string> LinqBegin34()
        {
            List<int> A = new List<int>()
            {
                53,
                -1,
                -5,
                -5,
                53,
                3,
                -4,
                100,
                84,
                100,
                81
            };
            return A.Where(x => x > 0 && x % 2 != 0).Select(x => x.ToString()).OrderBy(x => x);
        }
        static IEnumerable<int> LinqBegin35()
        {
            List<int> A = new List<int>()
            {
                53,
                53,
                -1,
                -5,
                -5,
                53,
                3,
                -4,
                100,
                84,
                100,
                81
            };
            int i = 0;
            return A.Select(x => (i++)*x).Where(x => x > 9 && x < 100).Reverse();
        }
        static IEnumerable<char> LinqBegin36()
        {
            List<string> A = new List<string>()
            {
                "A1e",
                "B1",
                "F1eq",
                "C1eqe",
                "W1eqe",
                "F1eq",
                "q21eqweq",
                "qfwrgeq",
                "3rwrsdf"
            };
            return A.Select(x => x.Length % 2 != 0 ? x[0] : x[x.Length - 1]).OrderByDescending(x => x);
        }
        static IEnumerable<string> LinqBegin37()
        {
            List<string> A = new List<string>()
            {
                "A1e",
                "B1",
                "F1eq",
                "C1eqe",
                "W1eqe",
                "F1eq",
                "q21eqweq",
                "qfwrgeq",
                "3rwrsdf"
            };
            int i = 1;
            return A.Where(x => x[0] >= 'A' && x[0] <= 'Z').Select(x => $"{x}{i++}").Where(x => x.Length != 1).OrderBy(x => x);
        }
        static IEnumerable<int> LinqBegin38()
        {
            List<int> A = new List<int>()
            {
                53,
                53,
                -1,
                -5,
                -5,
                53,
                3,
                -4,
                100,
                84,
                100,
                81
            };
            return A.Where(x => x % 3 != 0).Select(x => x % 3 == 1 ? x * x : x);
        }
        static IEnumerable<char> LinqBegin39()
        {
            List<string> A = new List<string>()
            {
                "A21e",
                "B1",
                "F1eq",
                "C1eqe",
                "W1eqe",
                "F1eq",
                "q21eqweq",
                "qfwrgeq",
                "3rwrsdf"
            };
            return A.SelectMany(x => x.Where(y => y >= '0' && y <= '9'));
        }
        static IEnumerable<char> LinqBegin40(int K)
        {
            List<string> A = new List<string>()
            {
                "A21e",
                "B1",
                "F1eq",
                "C1eqe",
                "W1eqe",
                "F1eq",
                "q21eqweq",
                "qfwrgeq",
                "3rwrsdf"
            };
            return A.Where(x => x.Length >= K).SelectMany(x =>  x.Select(y => y)).Reverse();
        }
        //static IEnumerable<string> LinqBegin41(int K)
        //{
        //    List<string> A = new List<string>()
        //    {
        //        "A21.E",
        //        "B1",
        //        "F1eq",
        //        "C1eqe",
        //        "W1eqe",
        //        "F1eq",
        //        "q21eqweq",
        //        "qfwrgeq",
        //        "3rwrsdf"
        //    };
        //    return A.SelectMany(x => x.Contains('.') ? );
        //}
        static IEnumerable<char> LinqBegin42()
        {
            List<string> A = new List<string>()
            {
                "A21E",
                "B1",
                "F1eq",
                "C1eqe",
                "W1eqe",
                "F1eq",
                "q21eqweq",
                "qfwrgeq",
                "3rwrsdf"
            };
            int i = 0;
            return A.SelectMany(x => i++ % 2 == 0 ? x.Where(y => y >= 'a' && y <= 'z') : x.Where(y => y >= 'A' && y <= 'Z'));
        }
        //static IEnumerable<char> LinqBegin43(int K)
        //{
        //    List<string> A = new List<string>()
        //    {
        //        "A21E",
        //        "B1",
        //        "F1eq",
        //        "C1eqe",
        //        "W1eqe",
        //        "F1eq",
        //        "q21eqweq",
        //        "qfwrgeq",
        //        "3rwrsdf"
        //    };
        //    int i = 0;
        //    return A.SelectMany(x => i++ % 2 == 0 ? x.Where(y => y >= 'a' && y <= 'z') : x.Where(y => y >= 'A' && y <= 'Z')).Reverse();
        //}
        static IEnumerable<int> LinqBegin44(int K1, int K2)
        {
            List<int> A = new List<int>()
            {
                53,
                53,
                -1,
                -5,
                -5,
                53,
                3,
                -4,
                100,
                84,
                100,
                81
            };
            List<int> B = new List<int>()
            {
                23,
                -12,
                45,
                2,
                53,
                -23,
                856,
                -76
            };
            return A.Where(x => x > K1).Concat(B.Where(x => x < K2)).OrderBy(x => x);
        }
        static IEnumerable<string> LinqBegin45(int L1, int L2)
        {
            List<string> A = new List<string>()
            {
                "123D12SD",
                "123DDEW",
                "12AD2E",
                "DEW23D",
                "12SAD2E",
                "DAD2DS",
                "WE2FDWEF",
                "GRTG34",
                "FERFE",
                "FQWEF23",
                "2WED2Q3",
                "FWEFWEF"
            };
            List<string> B = new List<string>()
            {
                "FQWE32D",
                "D32DQ",
                "12EDASF",
                "2E2DWD",
                "DW32DS",
                "3DWD32D",
                "DQWED3",
                "23D2D"
            };
            return A.Where(x => x.Length == L1).Concat(B.Where(x => x.Length == L2)).OrderByDescending(x => x);
        }
        static IEnumerable<string> LinqBegin46()
        {
            List<int> A = new List<int>()
            {
                53,
                1,
                5,
                3,
                4,
                100,
                84,
                81
            };
            List<int> B = new List<int>()
            {
                23,
                12,
                45,
                2,
                53,
                856,
                76
            };
            return A.Join(B, x => x.ToString()[x.ToString().Length - 1], y => y.ToString()[y.ToString().Length - 1], (x, y) => x.ToString()[0] != y.ToString()[0] ? Convert.ToString($"{x}-{y}") : Convert.ToString($"{y}-{x}"));
        }
        static IEnumerable<string> LinqBegin47()
        {
            List<int> A = new List<int>()
            {
                53,
                1,
                5,
                3,
                4,
                100,
                84,
                21
            };
            List<int> B = new List<int>()
            {
                23,
                12,
                45,
                2,
                53,
                856,
                76
            };
            return A.Join(B, x => x.ToString()[x.ToString().Length - 1], y => y.ToString()[0], (x, y) => x.ToString()[0] != y.ToString()[0] ? Convert.ToString($"{x}:{y}") : Convert.ToString($"{y}:{x}")).OrderBy(x => x);
        }
        static IEnumerable<string> LinqBegin48()
        {
            List<string> A = new List<string>()
            {
                "123D12SD",
                "123DDEW",
                "12AD2E",
                "DEW23D",
                "12SAD2E",
                "DAD2DS",
                "WE2FDWEF",
                "GRTG34",
                "FERFE",
                "FQWEF23",
                "2WED2Q3",
                "FWEFWEF"
            };
            List<string> B = new List<string>()
            {
                "FQWE32D",
                "D32DQ",
                "12EDASF",
                "2E2DWD",
                "DW32DS",
                "3DWD32D",
                "DQWED3",
                "23D2D"
            };
            return A.Join(B, x => x.Length, y => y.Length, (x, y) => x.ToString()[0] != y.ToString()[0] ? Convert.ToString($"{x.OrderBy(x1 => x1)}:{y}") : Convert.ToString($"{y.OrderByDescending(y1 => y1)}:{x}"));
        }
        //static IEnumerable<string> LinqBegin49()
        //{
        //    List<string> A = new List<string>()
        //    {
        //        "123D12SD",
        //        "123DDEW",
        //        "12AD2E",
        //        "DEW23D",
        //        "12SAD2E",
        //        "DAD2DS",
        //        "WE2FDWEF",
        //        "GRTG34",
        //        "FERFE",
        //        "FQWEF23",
        //        "2WED2Q3",
        //        "FWEFWEF"
        //    };
        //    List<string> B = new List<string>()
        //    {
        //        "FQWE32D",
        //        "D32DQ",
        //        "12EDASF",
        //        "2E2DWD",
        //        "DW32DS",
        //        "3DWD32D",
        //        "DQWED3",
        //        "23D2D"
        //    };
        //    List<string> C = new List<string>()
        //    {
        //        "FWAFE32D",
        //        "DEFDQ",
        //        "WEF3EDASF",
        //        "3WFWDAS",
        //        "WFEW32DS3R",
        //        "NGHWD32D",
        //        "5HGFHWED3ASF",
        //        "23DAS2DASF"
        //    };
        //    return A.GroupJoin(B, C, x => x[0], y => y[0], y => y[0], (x, y, z) => x.ToString()[0] != y.ToString()[0] ? Convert.ToString($"{x.OrderBy(x1 => x1)}:{y}") : Convert.ToString($"{y}:{x}"));
        //}


    }
}
