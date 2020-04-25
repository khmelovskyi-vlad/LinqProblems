using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Test
    {
        public Test()
        {

        }
        public void Run()
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem4a2();
            Problem5();
            Problem6();
            Problem7();
            Problem8();
            Problem9();
            Problem10();
            Problem11();
            Problem12();
            Problem13();
            Problem14();
            Problem15();
            Problem16();
            Problem17();
            Problem18();
            Problem19();
            Problem20();
            Problem21();
            Problem22();
            Problem23();
            Problem24();
            Problem25();
            Problem26();
            Problem27();
            Problem28();
            Problem29();
            Problem30();
            Problem31();
            Problem32();
            Problem33();
            Problem34();
            Problem35();
            Problem36();
            Problem37();
            Problem38();
            Problem39();
            Problem40();
            Problem41();
            Problem42();
            Problem43();
            Problem44();
            Problem45();
            Problem46();
            Problem47();
            Problem48();
            Problem49();
            Problem50();
            Problem51();
            Problem52();
            Problem53();
            Problem54();
            Problem55();
            Problem56();
            Problem57();
            Problem58();
            Problem59();
            Problem60();
        }
        static void Problem1()
        {
            List<int> problem1 = new List<int>()
            {
                3,
                -8,
                1,
                2,
                -5,
                3
            };
            var answer1 = problem1.First(x => x > 0);
            var answer2 = problem1.Last(x => x < 0);
            Console.WriteLine("Problem1");
            Console.WriteLine($"first = {answer1}, second = {answer2}");
        }
        static void Problem2()
        {
            var D = 1;
            List<int> A = new List<int>()
            {
                23,
                -51,
                -28,
                41,
                26,
                38
            };
            var answer1 = A.FirstOrDefault(x => x > 0 && Convert.ToString(x)[Convert.ToString(x).Length - 1] == Convert.ToString(D)[0]);
            Console.WriteLine("Problem2");
            Console.WriteLine($"first = {answer1}");
        }
        static void Problem3()
        {
            var L = 8;
            List<string> A = new List<string>()
            {
                "12fsdfsf",
                "sdfsdf223fwdf",
                "8",
                "sdf34f8fdf",
                "5df34f8f",
                "23fsdf8sdf",
                "2fasfsdf8sdf",
                "dsad32dsdf"
            };
            var answer1 = A.LastOrDefault(x => x[0] >= '0' && x[0] <= '9' && x.Length == L);
            if (answer1 == null)
            {
                answer1 = "Not found";
            }
            Console.WriteLine("Problem3");
            Console.WriteLine($"first = {answer1}");
        }
        static void Problem4()
        {
            char C = '8';
            List<string> A = new List<string>()
            {
                "12fsdfsf",
                "sdfsdf223fwdf",
                "8",
                "sdf34f8fdf",
                "5df34f8f",
                "23fsdf8sdf",
                "2fasfsdf8sdf8",
                "dsad32dsdf"
            };
            var answer1 = A.Where(x => x[x.Length - 1] == C);
            Console.WriteLine("Problem4");
            switch (answer1.Count())
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine(answer1.First());
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        static void Problem4a2()
        {
            char C = '8';
            List<string> A = new List<string>()
            {
                "12fsdfsf",
                "sdfsdf223fwdf",
                "8",
                "sdf34f8fdf",
                "5df34f8f",
                "23fsdf8sdf",
                "2fasfsdf8sdf8",
                "dsad32dsdf"
            };
            Console.WriteLine("Problem4 - 2");
            try
            {
                var answer1 = A.SingleOrDefault(x => x[x.Length - 1] == C);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
        static void Problem5()
        {
            char C = '8';
            List<string> A = new List<string>()
            {
                "12fsdfsf",
                "sdfsdf223fwdf",
                "88",
                "8",
                "sdf34f8fdf",
                "5df34f8f",
                "23fsdf8sdf",
                "82fasfsdf8sdf8",
                "dsad32dsdf"
            };
            Console.WriteLine("Problem5");
            var answer1 = A.Count(x => x.Length > 1 && x[0] == C && x[x.Length - 1] == C);
            Console.WriteLine(answer1);
        }
        static void Problem6()
        {
            List<string> A = new List<string>()
            {
                "12fsdfsf",
                "sdfsdf223fwdf",
                "88",
                "8",
                "sdf34f8fdf",
                "5df34f8f",
                "23fsdf8sdf",
                "82fasfsdf8sdf8",
                "dsad32dsdf"
            };
            Console.WriteLine("Problem6");
            var answer1 = A.Aggregate((x,y) => x + y).Count();
            Console.WriteLine(answer1);
        }
        static void Problem7()
        {
            List<int> A = new List<int>()
            {
                1,
                6,
                8,
                56,
                456,
                8
            };
            Console.WriteLine("Problem7");
            //try
            //{
                var answer1 = A.Count(x => x < 0);
                if (answer1 == 0)
                {
                    Console.WriteLine("00");
                    return;
                }
                var answer2 = A.Where(x => x < 0).Sum();
                Console.WriteLine($"{answer1}, {answer2}");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("00");
            //}
        }
        static void Problem8()
        {
            List<int> A = new List<int>()
            {
                1,
                6,
                8,
                56,
                41,
                42,
                456,
                8
            };
            Console.WriteLine("Problem8");
            //try
            //{
            var answer1 = A.Count(x => x > 9 && x < 100);
            if (answer1 == 0)
            {
                Console.WriteLine("00");
                return;
            }
            var answer2 = A.Where(x => x > 9 && x < 100).Average();
            Console.WriteLine($"{answer1}, {answer2}");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("00");
            //}
        }
        static void Problem9()
        {
            List<int> A = new List<int>()
            {
                -1,
                -6,
                -8,
                -56,
                -41,
                -42,
                -456,
                -8
            };
            Console.WriteLine("Problem9");
            try
            {
                var answer1 = A.Where(x => x >= 0).Min();
                Console.WriteLine(answer1);
            }
            catch (Exception)
            {
                Console.WriteLine("0");
            }
        }
        static void Problem10()
        {
            var L = 8;
            List<string> A = new List<string>()
            {
                "FSDFSF",
                "SDFSDF223FWDF",
                "SF",
                "FGNFGN",
                "SDFFFDF",
                "DFFF",
                "FSDF8SDF",
                "FAAAAAAA",
                "FASFSDFSDF",
                "DSADDSDF"

            };
            Console.WriteLine("Problem10");
            var answer1 = A.Where(x => x.Length == L).Max();
            if (answer1 == null)
            {
                Console.WriteLine();
                return;
            }
            Console.WriteLine(answer1);
        }
        static void Problem11()
        {
            List<string> A = new List<string>()
            {
                "AB",
                "CD",
                "FG"

            };
            Console.WriteLine("Problem11");
            var answer1 = A.Aggregate(new StringBuilder(), (x, y) => x.Append(y[0]));
            Console.WriteLine(answer1);
        }
        static void Problem12()
        {
            List<int> A = new List<int>()
            {
                5,
                123,
                23,
                532,
                6
            };
            Console.WriteLine("Problem12");
            var answer1 = A.Aggregate(1, (x, y) => x * Convert.ToInt32(y.ToString()[y.ToString().Length - 1].ToString()));
            Console.WriteLine(answer1);
        }
        static void Problem13()
        {
            var N = 17;
            Console.WriteLine("Problem13");
            var answer1 = Enumerable.Range(1, N).Sum(x => (double)1/x);
            Console.WriteLine(answer1);
        }
        static void Problem14()
        {
            var A = 8;
            var B = 17;
            Console.WriteLine("Problem14");
            var answer1 = Enumerable.Range(A, B - A + 1).Average(x => x*x);
            Console.WriteLine(answer1);
        }
        static void Problem15()
        {
            var N = 5;
            Console.WriteLine("Problem15");
            try
            {
                var answer1 = Enumerable.Range(1, N).Aggregate((x, y) => x * y);
                Console.WriteLine(answer1);
            }
            catch (Exception)
            {
                Console.WriteLine(1);
            }
        }
        static void Problem16()
        {
            List<int> A = new List<int>()
            {
                5,
                -123,
                -23,
                532,
                6
            };
            Console.WriteLine("Problem16");
            var B = A.Where(x => x > 0);
            OutputInt(B);
        }
        static void Problem17()
        {
            Console.WriteLine("Problem17");
            List<int> A = new List<int>()
            {
                5,
                -123,
                -23,
                532,
                6,
                6
            };
            var B = A.Where(x => x % 2 != 0).Distinct();
            OutputInt(B);
        }
        static void Problem18()
        {
            Console.WriteLine("Problem18");
            List<int> A = new List<int>()
            {
                5,
                -58,
                -123,
                -23,
                -22,
                532,
                6,
                6,
                -16874
            };
            var B = A.Where(x => x % 2 == 0 && x < 0).Reverse();
            OutputInt(B);
        }
        static void Problem19()
        {
            Console.WriteLine("Problem19");
            var D = 7;
            List<int> A = new List<int>()
            {
                5,
                -58,
                -127,
                -27,
                -22,
                537,
                7,
                6,
                537,
                -16874
            };
            var B = A.Where(x => x.ToString()[x.ToString().Length - 1].ToString() == D.ToString() && x > 0).Reverse().Distinct().Reverse();
            OutputInt(B);
        }
        static void Problem20()
        {
            Console.WriteLine("Problem20");
            List<int> A = new List<int>()
            {
                5,
                -58,
                -127,
                -27,
                -22,
                37,
                7,
                34,
                6,
                38,
                37,
                -16874
            };
            var B = A.Where(x => x > 9 && x < 100 && x > 0).Reverse().OrderBy(x => x);
            OutputInt(B);
        }
        static void Problem21()
        {
            Console.WriteLine("Problem21");
            List<string> A = new List<string>()
            {
                "FSDFSF",
                "SDFSDFFWDF",
                "SF",
                "SA",
                "SQ",
                "FGNFGN",
                "SDFFFDF",
                "DFFF",
                "FSDFSDF",
                "FAAAAAAA",
                "FASFSDFSDF",
                "DSADDSDF"
            };
            var B = A.OrderBy(x => x.Length).ThenByDescending(x => x);
            OutputString(B);
        }
        static void Problem22()
        {
            Console.WriteLine("Problem22");
            var K = 5;
            List<string> A = new List<string>()
            {
                "FS2546DF56SF",
                "SDFSDF2356523FWDF4",
                "SF3",
                "WEF2R",
                "FGNFG56N4",
                "SDF45FFD5F2",
                "D3FF",
                "D3FF4",
                "FSD54F8SDF",
                "FAA6AAAAA",
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            var B = A.Where(x => x.Length == K && x[x.Length - 1] >= '0' && x[x.Length - 1] <= '9').OrderBy(x => x);
            OutputString(B);
        }
        static void Problem23()
        {
            Console.WriteLine("Problem23");
            var K = 5;
            List<int> A = new List<int>()
            {
                5,
                -58,
                -127,
                -27,
                -22,
                37,
                7,
                34,
                6,
                39,
                37,
                -16874
            };
            var B = A.Skip(K).Where(x => x % 2 != 0 && x > 9 && x < 100).OrderByDescending(x => x);
            OutputInt(B);
        }
        static void Problem24()
        {
            Console.WriteLine("Problem24");
            var K = 5;
            List<string> A = new List<string>()
            {
                "FS2546DF56SF",
                "SDFSDF2356523FWDF4",
                "SF3",
                "WEF2R",
                "FGNFG56N4",
                "SDF45FFD5F2",
                "D3FF",
                "D3FF4",
                "FSD54F8SDF",
                "FAA6AAAAA",
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            var B = A.Take(K).Where(x => x.Length % 2 != 0 && x[0] >= 'A' && x[0] <= 'Z').Reverse();
            OutputString(B);
        }
        static void Problem25()
        {
            Console.WriteLine("Problem25");
            var K1 = 5;
            var K2 = 9;
            List<int> A = new List<int>()
            {
                5,
                -58,
                -127,
                -27,
                -22,
                37,
                7,
                -34,
                6,
                39,
                37,
                -16874
            };
            var B = A.Skip(K1).Take(K2 - K1).Where(x => x > 0).Sum();
            Console.WriteLine(B);
        }
        static void Problem26()
        {
            Console.WriteLine("Problem25");
            var K1 = 3;
            var K2 = 8;
            List<int> A = new List<int>()
            {
                5,
                -59,
                -127,
                -27,
                -22,
                37,
                7,
                -34,
                6,
                39,
                37,
                -16874
            };
            var B = A.Take(K2 - K1 + 1).Skip(K1 - 1).Average(x => (double)x);
            Console.WriteLine(B);
        }
        static void Problem27()
        {
            Console.WriteLine("Problem27");
            var D = 8;
            List<int> A = new List<int>()
            {
                5,
                -59,
                -127,
                -27,
                -22,
                8,
                7,
                37,
                -34,
                6,
                39,
                37,
                -16874
            };
            var B = A.SkipWhile(x => x <= D).Where(x => x % 2 != 0 && x > 0).Reverse();
            OutputInt(B);
        }
        static void Problem28()
        {
            Console.WriteLine("Problem28");
            var L = 10;
            List<string> A = new List<string>()
            {
                "SF3A",
                "FGNFG56NA",
                "ASF3A",
                "WEF2R",
                "SDF45FFD5F2",
                "D3FF",
                "FS2546DF56SF",
                "D3FF4",
                "FSD54F8SDF",
                "FAA6AAAAA",
                "SDFSDF2356523FWDF4",
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            var B = A.TakeWhile(x => x.Length < L).Where(x => x[x.Length - 1] >= 'A' && x[x.Length - 1] <= 'Z').OrderByDescending(x => x.Length).ThenBy(x => x);
            OutputString(B);
        }
        static void Problem29()
        {
            Console.WriteLine("Problem29");
            var D = 8;
            var K = 7;
            List<int> A = new List<int>()
            {
                -59,
                37,
                -127,
                37,
                -27,
                -22,
                8,
                5,
                7,
                5,
            };
            var first = A.TakeWhile(x => x < D);
            var second = A.Skip(K - 1);
            var B = first.Union(second).OrderByDescending(x => x);
            OutputInt(B);
        }
        static void Problem30()
        {
            Console.WriteLine("Problem30");
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            var K = 7;
            List<int> A = new List<int>()
            {
                -59,
                37,
                -127,
                37,
                -27,
                -22,
                -53,
                8,
                5,
                7,
                5,
            };
            var first = A.Where(x => x % 2 == 0);
            var second = A.Skip(K);
            var firstNeed = first.Except(second);
            var secondNeed = second.Except(first);
            var B = firstNeed.Union(secondNeed).Reverse();
            OutputInt(B);
        }
        static void Problem31()
        {
            Console.WriteLine("Problem31");
            var K = 10;
            IEnumerable<string> A = new List<string>()
            {
                "SF3A",
                "FS2546DF56SF",
                "FGNFG56NA",
                "ASF3A",
                "WEF2R",
                "SDF45FFD5F2",
                "D3FF",
                "D3FF4",
                "FSD54F8SDF",
                "SDFSDF2356523FWDF4",
                "12345",
                "R34F6",
                "SF3A",
                "FAS3FSDFSDF",
                "FAA6AAAAA",
                "FS2546DF56SF",
            };
            var first = A.Take(K);
            var second = A.Reverse().TakeWhile(x => x[x.Length - 1] <= '0' || x[x.Length - 1] >= '9');
            var B = first.Intersect(second).OrderBy(x => x.Length).ThenBy(x => x);
            OutputString(B);
        }
        static void Problem32()
        {
            Console.WriteLine("Problem32");
            List<string> A = new List<string>()
            {
                "SF3A",
                "FGNFG56NA",
                "ASF3A",
                "WEF2R",
                "SDF45FFD5F2",
                "D3FF",
                "FS2546DF56SF",
                "D3FF4",
                "FSD54F8SDF",
                "FAA6AAAAA",
                "SDFSDF2356523FWDF4",
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            var B = A.Select(x => x[0]).Reverse();
            OutputChar(B);
        }
        static void Problem33()
        {
            Console.WriteLine("Problem33");
            List<int> A = new List<int>()
            {
                -59,
                37,
                -127,
                37,
                -27,
                -22,
                -53,
                8,
                5,
                7,
                5,
            };
            var B = A.Where(x => x > 0).Select(x => Convert.ToInt32(x.ToString()[x.ToString().Length - 1].ToString())).Distinct();
            OutputInt(B);
        }
        static void Problem34()
        {
            Console.WriteLine("Problem34");
            List<int> A = new List<int>()
            {
                37,
                37,
                8,
                5,
                7,
                5,
            };
            var B = A.Where(x => x % 2 != 0).Select(x => x.ToString()).OrderBy(x => x);
            OutputString(B);
        }
        static void Problem35()
        {
            Console.WriteLine("Problem35");
            List<int> A = new List<int>()
            {
                -59,
                37,
                -127,
                37,
                -27,
                -22,
                -53,
                8,
                5,
                7,
                5,
            };
            int i = 1;
            var B = A.Select(x => (i++)*x).Where(x => x > 9 && x < 100).Reverse();
            OutputInt(B);
        }
        static void Problem36()
        {
            Console.WriteLine("Problem36");
            List<string> A = new List<string>()
            {
                "SF3A",
                "FGNFG56NA",
                "ASF3A",
                "WEF2R",
                "SDF45FFD5F2",
                "D3FF",
                "FS2546DF56SF",
                "D3FF4",
                "FSD54F8SDF",
                "FAA6AAAAA",
                "SDFSDF2356523FWDF4",
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            var B = A.Select(x => x.Length % 2 != 0 ? x[0] : x[x.Length - 1]).OrderByDescending(x => x);
            OutputChar(B);
        }
        static void Problem37()
        {
            Console.WriteLine("Problem37");
            List<string> A = new List<string>()
            {
                "SFA",
                "FGNFFDSNA",
                "ASFA",
                "WEFR",
                "",
                "SDFFFDF",
                "",
                "DFF",
                "FSDFSF",
                "DFF",
                "",
                "FSDFSDF",
                "FAADFVAAAAA",
                "SDFSDFFWDF",
                "RRDRSDF",
                "FAS3FSDFSDF",
                "RF",
            };
            var i = 1;
            var B = A.Select(x => { if (x == "") { i++; return x = ""; } else return x = $"{x}{i++}"; }).Where(x => x != "").OrderBy(x => x);
            OutputString(B);
        }
        static void Problem38()
        {
            Console.WriteLine("Problem38");
            List<int> A = new List<int>()
            {
                -59,
                37,
                -127,
                37,
                -27,
                -22,
                -53,
                8,
                5,
                7,
                5,
            };
            var B = A.Where(x => x % 3 != 0).Select(x => x % 3 == 1 ? x * x : x);
            OutputInt(B);
        }
        static void Problem39()
        {
            Console.WriteLine("Problem39");
            List<string> A = new List<string>()
            {
                "SF3A",
                "FGNFG56NA",
                "ASF3A",
                "WEF2R",
                "SDF45FFD5F2",
                "D3FF",
                "FS2546DF56SF",
                "D3FF4",
                "FSD54F8SDF",
                "FAA6AAAAA",
                "SDFSDF2356523FWDF4",
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            var B = A.SelectMany(x => x.Where(y => y >= '0' && y <= '9'));
            OutputChar(B);
        }
        static void Problem40()
        {
            Console.WriteLine("Problem40");
            var K = 5;
            List<string> A = new List<string>()
            {
                "SF3A",
                "FGNFG56NA",
                "ASF3A",
                "WEF2R",
                "SDF45FFD5F2",
                "D3FF",
                "FS2546DF56SF",
                "D3FF4",
                "FSD54F8SDF",
                "FAA6AAAAA",
                "SDFSDF2356523FWDF4",
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            var B = A.Where(x => x.Length >= K).SelectMany(x => x).Reverse();
            OutputChar(B);
        }
        static void Problem41()
        {
            Console.WriteLine("Problem41");
            var K = 5;
            List<string> A = new List<string>()
            {
                "S.FA",
                "FGN.F.FDS.N.A",
                "A.SFA",
                "WE.F.R",
                "S.DFF.FD.F",
                "D.F.F",
                "F.SDFSF",
                "D.FF",
                "F.SDF.SDF",
                "FAADF.VAAAA.A",
                "S.DFSDF.FWDF",
                "RRD.RSDF",
                "FA.S3F.SDS.DF",
                "R.F",
            };
            var B = A.SelectMany(x => x.Split('.')).Where(x => x.Length == K).OrderBy(x => x);
            OutputString(B);
        }
        static void Problem42()
        {
            Console.WriteLine("Problem42");
            List<string> A = new List<string>()
            {
                "SFfdfe3Aef",
                "FGwefNFqwef5f6N",
                "ASqwefF3qefA",
                "WEqwefF2qefR",
            };
            var i = 1;
            var B = A.SelectMany(x => i++ % 2 != 0 ? x.Where(y => y >= 'A' && y <= 'Z') : x.Where(y => y >= 'a' && y <= 'z'));
            OutputChar(B);
        }
        static void Problem43()
        {
            Console.WriteLine("Problem43");
            var K = 1;
            List<string> A = new List<string>()
            {
                "SF3A",
                "FGNFG56NA",
                "ASF3A",
                "WEF2R",
                "SDF45FFD5F2",
                "D3FF",
                "FS2546DF56SF",
                "D3FF4",
                "FSD54F8SDF",
                "FAA6AAAAA",
                "SDFSDF2356523FWDF4",
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            var j = 1;
            var i = 0;
            var B = A.SelectMany(x => { if (j <= K) { i = 0; j++; return x.Select(y => { if (i++ % 2 != 0) return default; else return y; }); }
                else { i = 0; j++; return x.Select(y => { if (i++ % 2 == 0) return default; else return y; }); }
            }).Where(x => x != default).Reverse();
            OutputChar(B);
        }
        static void Problem44()
        {
            Console.WriteLine("Problem44");
            var K1 = 5;
            var K2 = 7;
            List<int> A = new List<int>()
            {
                -59,
                32,
                37,
                -127,
                32,
            };
            List<int> B = new List<int>()
            {
                -127,
                37,
                -59,
                37,
            };
            var C = A.Where(x => x > K1).Concat(B.Where(x => x < K2)).OrderBy(x => x);
            OutputInt(C);
        }
        static void Problem45()
        {
            Console.WriteLine("Problem45");
            var L1 = 5;
            var L2 = 7;
            List<string> A = new List<string>()
            {
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            List<string> B = new List<string>()
            {
                "SF3A",
                "FGNFG56NA",
                "ASF3A",
                "WEF2R2F",
            };
            var C = A.Where(x => x.Length == L1).Concat(B.Where(x => x.Length == L2)).OrderByDescending(x => x);
            OutputString(C);
        }
        static void Problem46()
        {
            Console.WriteLine("Problem46");
            List<int> A = new List<int>()
            {
                169,
                77,
                17,
                32,
            };
            List<int> B = new List<int>()
            {
                127,
                87,
                19,
            };
            var C = A.Join(B,
                x => x.ToString()[x.ToString().Length - 1],
                y => y.ToString()[y.ToString().Length - 1],
                (x, y) => $"{x}-{y}");
            OutputString(C);
        }
        static void Problem47()
        {
            Console.WriteLine("Problem47");
            List<int> A = new List<int>()
            {
                869,
                77,
                87,
                32,
            };
            List<int> B = new List<int>()
            {
                737,
                91,
                727,
            };
            var b = B.OrderBy(x => x);
            var C = A.Join(b,
                x => x.ToString()[x.ToString().Length - 1],
                y => y.ToString()[0],
                (x, y) => $"{x}:{y}");
            OutputString(C);
        }
        static void Problem48()
        {
            Console.WriteLine("Problem48");
            List<string> A = new List<string>()
            {
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            List<string> B = new List<string>()
            {
                "FGNFG56NA6",
                "WEF2R2F2",
                "SF3A",
                "FK5M0",
                "ASF3A",
            };
            var a = A.OrderBy(x => x);
            var b = B.OrderByDescending(x => x);
            var C = a.Join(b,
                x => x.Length,
                y => y.Length,
                (x, y) => $"{x}:{y}");
            OutputString(C);
        }
        static void Problem49()
        {
            Console.WriteLine("Problem49");
            List<string> A = new List<string>()
            {
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            List<string> B = new List<string>()
            {
                "FGNFG56NA6",
                "1WEF2R2F2",
                "SF3A",
                "1FK5M0",
                "ASF3A",
            };
            List<string> C = new List<string>()
            {
                "YTF43FF",
                "HY87HUNFDF",
                "13434FDF3",
                "1DSD3",
                "43FWEF43F",
            };
            var b = B.OrderBy(x => x);
            var c = C.OrderByDescending(x => x);
            var V = A.Join(b,
                x => x[0],
                y => y[0],
                (x, y) => $"{x}={y}")
                .Join(c,
                x => x[0],
                y => y[0],
                (x, y) => $"{x}={y}");
            OutputString(V);
        }
        static void Problem50()
        {
            Console.WriteLine("Problem50");
            List<string> A = new List<string>()
            {
                "RR3R6",
                "FAS3FSDFSDF",
                "1R34F6",
                "T2345"
            };
            List<string> B = new List<string>()
            {
                "FGNFG56NA6",
                "1WEF2R2F2",
                "SF3A",
                "1FK5M0",
                "ASF3A",
            };
            var C = A.GroupJoin(B,
                x => x[0],
                y => y[0],
                (x, y) => $"{x}:{y.Count()}");
            OutputString(C);
        }
        static void Problem51()
        {
            Console.WriteLine("Problem51");
            List<int> A = new List<int>()
            {
                869,
                77,
                87,
                32,
            };
            List<int> B = new List<int>()
            {
                737,
                12,
                727,
                12,
                52,
            };
            var C = A.GroupJoin(B,
                x => x.ToString().Last(),
                y => y.ToString().Last(),
                (x, y) => $"{y.Sum()}:{x}")
                .OrderBy(x => Convert.ToInt32(x.Split(':')[0]))
                .ThenByDescending(x => Convert.ToInt32(x.Split(':')[1]));
            OutputString(C);
        }
        static void Problem52()
        {
            Console.WriteLine("Problem52");
            List<string> A = new List<string>()
            {
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            List<string> B = new List<string>()
            {
                "FGNFG56NA6",
                "WEF2R2F2",
                "SF3A",
                "ASF3A",
            };
            var a = A.Where(x => x.Last() >= '0' && x.Last() <= '9').OrderBy(x => x);
            var b = B.Where(x => x.Last() >= '0' && x.Last() <= '9').OrderByDescending(x => x);
            var C = a.SelectMany(x => b.Select(y => $"{x}={y}"));
            OutputString(C);
        }
        static void Problem53()
        {
            Console.WriteLine("Problem53");
            List<int> A = new List<int>()
            {
                869,
                77,
                87,
                32,
            };
            List<int> B = new List<int>()
            {
                737,
                12,
                727,
                12,
                52,
            };
            var C = A.SelectMany(x => B.Select(y => x + y))
                .OrderBy(x => x);
            OutputInt(C);
        }
        static void Problem54()
        {
            Console.WriteLine("Problem54");
            List<string> A = new List<string>()
            {
                "RR3R6",
                "FAS3FSDFSDF",
                "R34F6",
                "12345"
            };
            List<string> B = new List<string>()
            {
                "FGNFG56NA6",
                "WEF2R2F2",
                "SF3A",
                "FF3F6",
                "ASF3A",
            };
            var C = A.GroupJoin(B,
                x => x[0],
                y => y[0],
                //(x, y) => y.Count() == 0 ? new List<string>() { $"{x}." } : y.Select(y1 => $"{x}.{y1}"))
                (x, y) => y.DefaultIfEmpty("").Select(y1 => $"{x}.{y1}"))
                .SelectMany(x => x)
                .OrderBy(x => x);
            OutputString(C);
        }
        static void Problem55()
        {
            Console.WriteLine("Problem55");
            List<int> A = new List<int>()
            {
                869,
                1,
                77,
                87,
                32,
            };
            List<int> B = new List<int>()
            {
                737,
                12,
                727,
                52,
            };
            var C = A.GroupJoin(B,
                x => x.ToString().Last(),
                y => y.ToString().Last(),
                //(x, y) => y.Count() == 0 ? new List<string>() { $"{x}:0" } : y.Select(y1 => $"{x}:{y1}"))
                (x, y) => y.DefaultIfEmpty(0).Select(y1 => $"{x}:{y1}"))
                .SelectMany(x => x)
                .OrderByDescending(x => Convert.ToInt32(x.Split(':')[0]))
                .ThenBy(x => Convert.ToInt32(x.Split(':')[1]));
            OutputString(C);
        }
        static void Problem56()
        {
            Console.WriteLine("Problem56");
            List<int> A = new List<int>()
            {
                869,
                1,
                77,
                87,
                3212,
            };
            var C = A.GroupJoin(A,
                x => x.ToString().Last(),
                y => y.ToString().Last(),
                (x, y) => $"{x.ToString().Last()}:{y.Count()}")
                .Distinct()
                .OrderBy(x => x[0]);
            OutputString(C);
        }
        static void Problem57()
        {
            Console.WriteLine("Problem57");
            List<int> A = new List<int>()
            {
                869,
                19,
                1,
                77,
                2345679,
                87,
                1239,
                3212,
            };
            var C = A.GroupJoin(A,
                x => x.ToString().Last(),
                y => y.ToString().Last(),
                (x, y) => y.Count() == 1 ? " " : y.Max().ToString())
                .Where(x => x != " ")
                .Select(x => Convert.ToInt32(x))
                .Distinct()
                .OrderBy(x => x.ToString().Last());
            OutputInt(C);
        }
        static void Problem58()
        {
            Console.WriteLine("Problem58");
        }
        static void Problem59()
        {
            Console.WriteLine("Problem59");
        }
        static void Problem60()
        {
            Console.WriteLine("Problem60");
        }






        static void OutputInt(IEnumerable<int> data)
        {
            foreach (var oneData in data)
            {
                Console.Write($"{oneData}, ");
            }
            Console.WriteLine();
        }
        static void OutputString(IEnumerable<string> data)
        {
            foreach (var oneData in data)
            {
                Console.Write($"{oneData}, ");
            }
            Console.WriteLine();
        }
        static void OutputChar(IEnumerable<char> data)
        {
            foreach (var oneData in data)
            {
                Console.Write($"{oneData}, ");
            }
            Console.WriteLine();
        }

        static void LinqBegin3()
        {
            var L = 5;
            List<string> A = new List<string>()
            {
                "f1eqe",
                "21eqwe",
                "qfwrge",
                "3rwrsdf"
            };
            var num = A.Where(x => x[0] <= '9' && x[0] >= '0' && x.Count() == L).Reverse().Append("Not found").First();
            Console.WriteLine(num);
        }
    }
}
