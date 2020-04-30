using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class LinqObj
    {
        public void Run()
        {
            LinqObj1();
            LinqObj2();
            LinqObj3();
            LinqObj4();
            LinqObj5();
            LinqObj6();
            LinqObj7();
            LinqObj8();
            LinqObj9();
            LinqObj10();
            LinqObj11();
            LinqObj12();
            LinqObj13();
            LinqObj14();
            LinqObj15();
            LinqObj16();
            LinqObj17();
            LinqObj18();
            LinqObj19();
            LinqObj20();
            LinqObj21();
            LinqObj22();
            LinqObj23();
            LinqObj24();
        }
        class LinqObj1_12
        {
            public LinqObj1_12(int ClientCode, int Year, int MonthNum, int ClassDuration)
            {
                this.ClientCode = ClientCode;
                this.Year = Year;
                this.MonthNum = MonthNum;
                this.ClassDuration = ClassDuration;
            }
            public int ClientCode { get; set; }
            public int Year { get; set; }
            public int MonthNum { get; set; }
            public int ClassDuration { get; set; }
        }
        private List<LinqObj1_12> linqObj1_12 = new List<LinqObj1_12>
        {
            new LinqObj1_12(1435, 2005, 3, 25),
            new LinqObj1_12(1435, 2006, 5, 37),
            new LinqObj1_12(1435, 2006, 3, 50),
            new LinqObj1_12(1435, 2007, 7, 21),
            new LinqObj1_12(4523, 2003, 5, 20),
            new LinqObj1_12(4523, 2003, 6, 19),
            new LinqObj1_12(4523, 2003, 7, 23),
            new LinqObj1_12(2439, 2007, 8, 25),
            new LinqObj1_12(2439, 2007, 3, 50),
            new LinqObj1_12(2439, 2007, 12, 23),
            new LinqObj1_12(9859, 2006, 4, 15),
            new LinqObj1_12(5234, 2007, 1, 20),
            new LinqObj1_12(5234, 2007, 2, 25),
            new LinqObj1_12(5234, 2007, 3, 24),
            new LinqObj1_12(5234, 2007, 2, 50),
            new LinqObj1_12(5234, 2007, 4, 27),
            new LinqObj1_12(5234, 2007, 5, 23),
            new LinqObj1_12(5234, 2007, 6, 29),
            new LinqObj1_12(2349, 2006, 6, 28),
            new LinqObj1_12(2349, 2006, 8, 30),
            new LinqObj1_12(2349, 2006, 9, 30),
            new LinqObj1_12(2349, 2007, 3, 23),
            new LinqObj1_12(2349, 2018, 2, 100),
            new LinqObj1_12(2349, 2018, 5, 0),
            new LinqObj1_12(2349, 2019, 3, 28),
            new LinqObj1_12(2349, 2019, 6, 28),
            new LinqObj1_12(7543, 2005, 12, 15),
            new LinqObj1_12(7543, 2006, 10, 185),
            new LinqObj1_12(7543, 2006, 11, 19),
            new LinqObj1_12(7543, 2007, 10, 26),
            new LinqObj1_12(7543, 2007, 12, 24),
        };
        class LinqObj13_24
        {
            public LinqObj13_24(int IntroductionYear, int SchoolNum, string Surname)
            {
                this.IntroductionYear = IntroductionYear;
                this.SchoolNum = SchoolNum;
                this.Surname = Surname;
            }
            public int IntroductionYear { get; set; }
            public int SchoolNum { get; set; }
            public string Surname { get; set; }
        }
        private List<LinqObj13_24> linqObj13_24 = new List<LinqObj13_24>
        {
            new LinqObj13_24(2003, 1234, "Qweasd"),
            new LinqObj13_24(2003, 1234, "Wqeqwd"),
            new LinqObj13_24(2003, 1234, "Qacsc"),
            new LinqObj13_24(2003, 4123, "Ggdfdfbdfb"),
            new LinqObj13_24(2003, 1415, "Yhfgbnfgb"),
            new LinqObj13_24(2004, 1865, "Cdfbdfr"),
            new LinqObj13_24(2004, 6456, "Lkvjdfvnjn"),
            new LinqObj13_24(2004, 6544, "Prnbfbdv"),
            new LinqObj13_24(2004, 3753, "Mfdbewfewc"),
            new LinqObj13_24(2006, 6456, "Lsdfwecwv"),
            new LinqObj13_24(2006, 7564, "Tdfvdfvsd"),
            new LinqObj13_24(2006, 4356, "Psdvevfvgfb"),
            new LinqObj13_24(2006, 7254, "Isdverwq"),
            new LinqObj13_24(2006, 6427, "Bsfe"),
            new LinqObj13_24(2007, 7824, "Ksdvtner"),
            new LinqObj13_24(2007, 7256, "Xsvwsevewv"),
            new LinqObj13_24(2007, 3168, "Lsvwev"),
            new LinqObj13_24(2008, 6245, "Qvdbrebr"),
            new LinqObj13_24(2008, 9145, "Lvbedbwq"),
            new LinqObj13_24(2008, 2658, "Qsdvesv"),
            new LinqObj13_24(2008, 1243, "Lsbklwebvjbhj"),
            new LinqObj13_24(2018, 4123, "Dsvdsv"),
            new LinqObj13_24(2019, 4123, "Vdfgber"),
        };
        private void LinqObj1()
        {
            Console.WriteLine("LinqObj1");
            var min = linqObj1_12.OrderByDescending(x => x.ClassDuration).Last();
            Console.WriteLine($"{min.ClassDuration} {min.Year} {min.MonthNum}");
        }
        private void LinqObj2()
        {
            Console.WriteLine("LinqObj2");
            var max = linqObj1_12.OrderBy(x => x.ClassDuration)
                .ThenBy(x => x.Year)
                .ThenBy(x => x.MonthNum)
                .Last();
            Console.WriteLine($"{max.ClassDuration} {max.Year} {max.MonthNum}");
        }
        private void LinqObj3()
        {
            Console.WriteLine("LinqObj3");
            var max = linqObj1_12.GroupBy(e => e.Year,
                (k, g) => new { k, sum = g.Sum(x => x.ClassDuration) })
                .OrderBy(x => x.sum)
                .ThenByDescending(x => x.k)
                .Last();
            Console.WriteLine($"{max.k} {max.sum}");
        }
        private void LinqObj4()
        {
            Console.WriteLine("LinqObj4");
            var results = linqObj1_12.Select(x => new { x.ClassDuration, x.ClientCode })
                .GroupBy(e => e.ClientCode,
                (k, g) => new { k, sum = g.Sum(x => x.ClassDuration) })
                .OrderByDescending(x => x.sum)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.sum} {result.k}");
            }
        }
        private void LinqObj5()
        {
            Console.WriteLine("LinqObj5");
            var results = linqObj1_12
                .GroupBy(e => e.ClientCode,
                (k, g) => new { k, sum = g.Count() })
                .OrderBy(x => x.sum)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.sum} {result.k}");
            }
        }
        private void LinqObj6()
        {
            Console.WriteLine("LinqObj6");
            var months = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            var results = months
                .GroupJoin(linqObj1_12,
                x => x,
                y => y.MonthNum,
                (x, y) => new { x, sum = y.Sum(y1 => y1.ClassDuration)})
                .OrderByDescending(x => x.sum)
                .ThenBy(x => x.x);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.sum} {result.x}");
            }
        }
        private void LinqObj7()
        {
            Console.WriteLine("LinqObj7");
            var K = 2349;
            var results = linqObj1_12.Where(x => x.ClientCode == K)
                .GroupBy(e => e.Year,
                (k, g) => new { k, group = g.OrderBy(x => x.ClassDuration).ThenByDescending(x => x.MonthNum)})
                .Select(x => x.group.Last())
                .OrderByDescending(x => x.Year);
            if (results.Count() == 0)
            {
                Console.WriteLine("No data");
            }
            else
            {
                foreach (var result in results)
                {
                    Console.WriteLine($"{result.Year} {result.MonthNum} {result.ClassDuration}");
                }
            }
        }
        private void LinqObj8()
        {
            Console.WriteLine("LinqObj8");
            var K = 2349;
            var results = linqObj1_12.Where(x => x.ClientCode == K && x.MonthNum != 0)
                .GroupBy(e => e.Year,
                (k, g) => new { k, group = g.OrderBy(x => x.ClassDuration) })
                .Select(x => x.group.First())
                .OrderBy(x => x.ClassDuration)
                .ThenBy(x => x.Year);
            if (results.Count() == 0)
            {
                Console.WriteLine("No data");
            }
            else
            {
                foreach (var result in results)
                {
                    Console.WriteLine($"{result.ClassDuration} {result.Year} {result.MonthNum}");
                }
            }
        }
        private void LinqObj9()
        {
            Console.WriteLine("LinqObj9");
            var K = 2349;
            var allYears = linqObj1_12.Where(x => x.ClientCode == K).Select(x => x.Year);
            var results = allYears
                .GroupJoin(linqObj1_12.Where(x => x.ClientCode == K && x.ClassDuration > 15),
                x => x,
                y => y.Year,
                (x, y) => new { year = x, count = y.Count() })
                .Distinct()
                .OrderByDescending(x => x.count)
                .ThenBy(x => x.year);
            if (results.Count() == 0)
            {
                Console.WriteLine("No data");
            }
            else
            {
                foreach (var result in results)
                {
                    Console.WriteLine($"{result.count} {result.year}");
                }
            }
            Console.WriteLine("result 2");
            var results2 = linqObj1_12.Where(x => x.ClientCode == K)
                .GroupBy(e => e.Year,
                (k, g) => new { year = k, count = g.Count(x => x.ClassDuration > 15) })
                .OrderByDescending(x => x.count)
                .ThenBy(x => x.year);
            if (results2.Count() == 0)
            {
                Console.WriteLine("No data");
            }
            else
            {
                foreach (var result in results2)
                {
                    Console.WriteLine($"{result.count} {result.year}");
                }
            }
        }
        private void LinqObj10()
        {
            Console.WriteLine("LinqObj10");
            Console.WriteLine(linqObj1_12.Count());
            var results = linqObj1_12
                .Select(x => new { x.ClientCode, couple = $"{x.Year}-{x.MonthNum}" })
                .GroupBy(e => e.couple,
                (k, g) => new { couple = k, count = g.Count() })
                .OrderByDescending(x => Convert.ToInt32(x.couple.Split('-')[0]))
                .ThenBy(x => Convert.ToInt32(x.couple.Split('-')[1]));
            foreach (var result in results)
            {
                Console.WriteLine($"{result.couple} {result.count}");
            }
        }
        private void LinqObj11()
        {
            Console.WriteLine("LinqObj11");
            Console.WriteLine(linqObj1_12.Count());
            var results = linqObj1_12
                .Select(x => new { x.ClassDuration, couple = $"{x.Year}-{x.MonthNum}" })
                .GroupBy(e => e.couple,
                (k, g) => new { couple = k, sum = g.Sum(x => x.ClassDuration) })
                .OrderBy(x => x.sum)
                .ThenByDescending(x => Convert.ToInt32(x.couple.Split('-')[0]))
                .ThenBy(x => Convert.ToInt32(x.couple.Split('-')[1]));
            foreach (var result in results)
            {
                Console.WriteLine($"{result.sum} {result.couple}");
            }
        }
        private void LinqObj12()
        {
            Console.WriteLine("LinqObj12");
            var P = 17;
            var results = linqObj1_12.GroupBy(e => e.Year,
                (k, g) => new { k, count = g.Count(x => x.ClassDuration > P*g.Sum(y => y.ClassDuration)/100) })
                .OrderByDescending(x => x.count)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.count} {result.k}");
            }
        }
        private void LinqObj13()
        {
            Console.WriteLine("LinqObj13");
            var results = linqObj13_24.GroupBy(e => e.IntroductionYear,
                (k, g) => new { k, max = g.Max(x => x.SchoolNum) })
                .OrderBy(x => x.max);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k} {result.max}");
            }
        }
        private void LinqObj14()
        {
            Console.WriteLine("LinqObj14");
            var results = linqObj13_24.GroupBy(e => e.IntroductionYear,
                (k, g) => new { k, count = g.Count() });
            var max = results.Max(x => x.count);
            var yearsCount = results.Count(x => x.count == max);
            Console.WriteLine(max);
            Console.WriteLine(yearsCount);
        }
        private void LinqObj15()
        {
            Console.WriteLine("LinqObj15");
            var results = linqObj13_24.GroupBy(e => e.IntroductionYear,
                (k, g) => new { k, count = g.Count() });
            var max = results.Max(x => x.count);
            var years = results.Where(x => x.count == max);
            Console.WriteLine(max);
            foreach (var year in years)
            {
                Console.WriteLine($"{year.k}");
            }
        }
        private void LinqObj16()
        {
            Console.WriteLine("LinqObj16");
            var results = linqObj13_24.GroupBy(e => e.IntroductionYear,
                (k, g) => new { k, count = g.Count() })
                .OrderByDescending(x => x.count)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.count} {result.k}");
            }
        }
        private void LinqObj17()
        {
            Console.WriteLine("LinqObj17");
            var results = linqObj13_24.Select(x => new { x.IntroductionYear, x.SchoolNum})
                .Distinct()
                .GroupBy(e => e.IntroductionYear,
                (k, g) => new { k, count = g.Count() })
                .OrderBy(x => x.count)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.count} {result.k}");
            }
        }
        private void LinqObj18()
        {
            Console.WriteLine("LinqObj18");
            var srZn = (double)linqObj13_24.Count() / linqObj13_24.Select(x => x.IntroductionYear).Distinct().Count();
            var results = linqObj13_24.GroupBy(e => e.IntroductionYear,
                (k, g) => new { k, count = g.Count() })
                .Where(x => x.count >= srZn)
                .OrderByDescending(x => x.count)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.count} {result.k}");
            }
        }
        private void LinqObj19()
        {
            Console.WriteLine("LinqObj19");
            var results = linqObj13_24.GroupBy(e => e.SchoolNum,
                (k, g) => new { k, count = g.Count(), first = g.First().Surname })
                .OrderBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k} {result.count} {result.first}");
            }
        }
        private void LinqObj20()
        {
            Console.WriteLine("LinqObj20");
            var results1 = linqObj13_24.GroupBy(e => e.SchoolNum,
                (k, g) => new {k, count = g.Count(), all = g.Select(x => x.Surname)});
            var max = results1.Max(x => x.count);
            var results = results1.Where(x => x.count == max)
                .OrderBy(x => x.k);
            foreach (var result in results)
            {
                foreach (var resultMin in result.all)
                {
                    Console.WriteLine($"{result.k} {resultMin}");
                }
            }
        }
        private void LinqObj21()
        {
            Console.WriteLine("LinqObj21");
            var results1 = linqObj13_24.GroupBy(e => e.SchoolNum,
                (k, g) => new { k, count = g.Count(), surname = g.OrderBy(x => x.Surname).First().Surname });
            var max = results1.Max(x => x.count);
            var results = results1.Where(x => x.count == max)
                .OrderBy(x => x.surname)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.surname} {result.k}");
            }
        }
        private void LinqObj22()
        {
            Console.WriteLine("LinqObj22");
            var results = linqObj13_24.GroupBy(e => e.SchoolNum,
                (k, g) => new { k, years = g.Select(x => x.IntroductionYear).Distinct().OrderBy(x => x) })
                .OrderBy(x => x.k);
            foreach (var result in results)
            {
                foreach (var resultMin in result.years)
                {
                    Console.WriteLine($"{result.k} {resultMin}");
                }
            }
        }
        private void LinqObj23()
        {
            Console.WriteLine("LinqObj23");
            var results = linqObj13_24.Select(x => new { yearSchool = $"{x.IntroductionYear}-{x.SchoolNum}", x.Surname})
                .GroupBy(e => e.yearSchool,
                (k, g) => new { k, count = g.Count()})
                .OrderByDescending(x => Convert.ToInt32(x.k.Split('-')[0]))
                .ThenBy(x => Convert.ToInt32(x.k.Split('-')[1]));
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k} {result.count}");
            }
        }
        private void LinqObj24()
        {
            Console.WriteLine("LinqObj24");
            var results = linqObj13_24.Select(x => new { yearSchool = $"{x.SchoolNum}-{x.IntroductionYear}", x.Surname })
                .GroupBy(e => e.yearSchool,
                (k, g) => new { k, firstThree = g.Select(x => x.Surname).Take(3) })
                .OrderBy(x => Convert.ToInt32(x.k.Split('-')[0]))
                .ThenByDescending(x => Convert.ToInt32(x.k.Split('-')[1]));
            foreach (var result in results)
            {
                foreach (var resultMin in result.firstThree)
                {
                    Console.WriteLine($"{result.k} {resultMin}");
                }
            }
        }
    }
}
