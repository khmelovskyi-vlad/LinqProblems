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
            new LinqObj1_12(2349, 2018, 2, 14),
            new LinqObj1_12(2349, 2018, 5, 0),
            new LinqObj1_12(2349, 2019, 3, 28),
            new LinqObj1_12(2349, 2019, 6, 28),
            new LinqObj1_12(7543, 2005, 12, 15),
            new LinqObj1_12(7543, 2006, 10, 185),
            new LinqObj1_12(7543, 2006, 11, 19),
            new LinqObj1_12(7543, 2007, 10, 26),
            new LinqObj1_12(7543, 2007, 12, 24),
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
            if (results.Count() == 0)
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
        }
        private void LinqObj11()
        {
            Console.WriteLine("LinqObj11");
        }
        private void LinqObj12()
        {
            Console.WriteLine("LinqObj12");
        }
    }
}
