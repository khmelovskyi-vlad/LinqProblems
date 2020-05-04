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
            LinqObj25();
            LinqObj26();
            LinqObj27();
            LinqObj28();
            LinqObj29();
            LinqObj30();
            LinqObj31();
            LinqObj32();
            LinqObj33();
            LinqObj34();
            LinqObj35();
            LinqObj36();
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
        class LinqObj25_36
        {
            public LinqObj25_36(string Surname, double Debt, int FlatNum)
            {
                this.FlatNum = FlatNum;
                this.Debt = Debt;
                this.Surname = Surname;
            }
            public string Surname { get; set; }
            public double Debt { get; set; }
            public int FlatNum { get; set; }
        }
        private List<LinqObj25_36> linqObj25_36 = new List<LinqObj25_36>
        {
            new LinqObj25_36("Qweasd2003", 123.34, 1),
            new LinqObj25_36("Vdfvdfvr", 7657.57, 2),
            new LinqObj25_36("Vsvevdv", 5668.45, 3),
            new LinqObj25_36("Vsdlkfn", 7654.12, 4),
            new LinqObj25_36("Jksdvksdv", 7511.56, 5),
            new LinqObj25_36("Lsdvlsdknvkd", 4784.30, 6),
            new LinqObj25_36("Bfdbfwlfnek", 751324.25, 7),
            new LinqObj25_36("Lsdfnwlfnek", 7231.36, 8),
            new LinqObj25_36("Nrlbnf", 873218.51, 9),
            new LinqObj25_36("Fdnyntn", 5467.58, 10),
            new LinqObj25_36("Rdbdfdfb", 0, 11),
            new LinqObj25_36("Bdberbfb", 567, 12),
            new LinqObj25_36("Fvsv", 564.13, 13),
            new LinqObj25_36("Ebdb", 78.64, 14),
            new LinqObj25_36("Mgwgf", 0, 15),
            new LinqObj25_36("Eebfdb", 875.15, 16),
            new LinqObj25_36("Jnntntn", 32135.78, 17),
            new LinqObj25_36("Cdscssdvsdv", 0, 18),
            new LinqObj25_36("Ftbrb", 7158.32, 19),
            new LinqObj25_36("Vbbfdb", 75115.35, 20),
            new LinqObj25_36("Vsdfveb", 78.58, 21),
            new LinqObj25_36("Rbbfgb", 234324.4, 22),
            new LinqObj25_36("Bgfbgt", 344.38, 23),
            new LinqObj25_36("Frebg", 0, 24),
            new LinqObj25_36("Igdrberb", 5675.46, 25),
            new LinqObj25_36("Ebfbt", 2575.34, 26),
            new LinqObj25_36("Vgh", 54234.84, 27),
            new LinqObj25_36("Btrym", 14.43, 28),
            new LinqObj25_36("Vdnytn", 0, 29),
            new LinqObj25_36("Ddfbtrh", 54.93, 30),
            new LinqObj25_36("Nnfnrg", 346.84, 31),
            new LinqObj25_36("Fisdnfm", 241.255, 32),
            new LinqObj25_36("Rbrtb", 4234.23, 33),
            new LinqObj25_36("Drbrbwef", 42346.42, 34),
            new LinqObj25_36("Fdfbtrb", 7453.45, 35),
            new LinqObj25_36("Rbeberb", 0, 36),
            new LinqObj25_36("Vdfberb", 23532.334, 37),
            new LinqObj25_36("Ebdfbtb", 236346.23, 38),
            new LinqObj25_36("Sfdvdrb", 4234.34, 39),
            new LinqObj25_36("Ddbrebtrb", 0, 40),
            new LinqObj25_36("Cdfberb", 1235.75, 41),
            new LinqObj25_36("Dnytnerf", 46342.65, 42),
            new LinqObj25_36("Uhegreg", 9623.12, 43),
            new LinqObj25_36("Dsberberb", 81827.23, 44),
            new LinqObj25_36("Csberb", 0, 45),
            new LinqObj25_36("Dwevwev", 3213.23, 46),
            new LinqObj25_36("Dwwefwef", 963845.12, 47),
            new LinqObj25_36("Dwevervrb", 67432.12, 48),
            new LinqObj25_36("Gwefewdwe", 5749.12, 49),
            new LinqObj25_36("Xsdberb", 96534.23, 50),
            new LinqObj25_36("Vswefewf", 653.23, 51),
            new LinqObj25_36("Xsberbeb", 0, 52),
            new LinqObj25_36("Fewbeb", 532.35, 53),
            new LinqObj25_36("Ewefwbb", 97654.21, 54),
            new LinqObj25_36("Fbeber", 6424234.83, 55),
            new LinqObj25_36("Dewberb", 214234.75, 56),
            new LinqObj25_36("Esvbrb", 0, 57),
            new LinqObj25_36("Dsbbrtb", 4235.23, 58),
            new LinqObj25_36("Csberbrb", 424.12, 59),
            new LinqObj25_36("Edfvdfbdf", 64545.23, 60),
            new LinqObj25_36("Dsdberb", 0, 61),
            new LinqObj25_36("Dsdverbreb", 8459.47, 62),
            new LinqObj25_36("Csdberb", 96485.23, 63),
            new LinqObj25_36("Deberb", 45823.65, 64),
            new LinqObj25_36("Wvervev", 92485.75, 65),
            new LinqObj25_36("Hbdfbdfb", 0, 66),
            new LinqObj25_36("Cdsvvv", 234.35, 67),
            new LinqObj25_36("Dsvebb", 4125.62, 68),
            new LinqObj25_36("Vdverb", 692834.32, 69),
            new LinqObj25_36("Grntyn", 64385.24, 70),
            new LinqObj25_36("Dbrtnrtn", 54723.23, 71),
            new LinqObj25_36("Dsdverbrb", 94582.75, 72),
            new LinqObj25_36("Vgnrtn", 5857363.34, 73),
            new LinqObj25_36("Mbrtbtrb", 0, 74),
            new LinqObj25_36("Jnrynytn", 34.23, 75),
            new LinqObj25_36("Kjnrtnnb", 9582.75, 76),
            new LinqObj25_36("Lwevsdvsdv", 858.65, 77),
            new LinqObj25_36("Csbebb", 5646.34, 78),
            new LinqObj25_36("Dsdbrrtn", 58673.76, 79),
            new LinqObj25_36("Csbeberb", 6778.64, 80),
            new LinqObj25_36("Cdberb", 94836.43, 81),
            new LinqObj25_36("Cdsverb", 3295.23, 82),
            new LinqObj25_36("Cebrtb", 6934.1, 83),
            new LinqObj25_36("Ddbdb", 234.43, 84),
            new LinqObj25_36("Fsdbdfb", 6345.32, 85),
            new LinqObj25_36("Jfgmfgn", 0, 86),
            new LinqObj25_36("Ktfdbdf", 24.75, 87),
            new LinqObj25_36("Fsdbsfgn", 6346.24, 88),
            new LinqObj25_36("Cdfbbfb", 0, 89),
            new LinqObj25_36("Ggewg", 21312.43, 90),
            new LinqObj25_36("Rerherh", 23423.12, 91),
            new LinqObj25_36("ASdsb", 6453.25, 92),
            new LinqObj25_36("Grtrtn", 0, 93),
            new LinqObj25_36("Vsdvfn", 234324.63, 94),
            new LinqObj25_36("Fsdvsdv", 2341.75, 95),
            new LinqObj25_36("Wdfbb", 58345.26, 96),
            new LinqObj25_36("Ferbf", 9346.24, 97),
            new LinqObj25_36("Dwef", 634.24, 98),
            new LinqObj25_36("Vberb", 0, 99),
            new LinqObj25_36("Wqwfsd", 6346.34, 100),
            new LinqObj25_36("Jrsgre", 5345.85, 101),
            new LinqObj25_36("Gsdv", 3648.23, 102),
            new LinqObj25_36("Vdberb", 74634.86, 103),
            new LinqObj25_36("Edgsg", 63424.34, 104),
            new LinqObj25_36("Knrtnrt", 14457.27, 105),
            new LinqObj25_36("Lgrgexc", 5345.86, 106),
            new LinqObj25_36("Qsdvdsv", 7245.54, 107),
            new LinqObj25_36("Hrtjtrj", 1345.65, 108),
            new LinqObj25_36("Gsgewg", 5.34, 109),
            new LinqObj25_36("Vdseve", 0, 110),
            new LinqObj25_36("Udfhdfh", 456.24, 111),
            new LinqObj25_36("Gdsbeb", 86345.23, 112),
            new LinqObj25_36("Gdnrn", 3454.52, 113),
            new LinqObj25_36("Vsdvew", 347.23, 114),
            new LinqObj25_36("Edsvdvdvsv", 65.23, 115),
            new LinqObj25_36("Vdsfdnrn", 7.12, 116),
            new LinqObj25_36("Jjrtjtj", 0, 117),
            new LinqObj25_36("Efsdfsd", 534.34, 118),
            new LinqObj25_36("Csdvbnr", 234.42, 119),
            new LinqObj25_36("Ssdvevv", 345.73, 120),
            new LinqObj25_36("Gejtrj", 12312.12, 121),
            new LinqObj25_36("Wgrerhenfg", 124.12, 122),
            new LinqObj25_36("Fdsdfbn", 0, 123),
            new LinqObj25_36("Fdhrtnnhn", 5325.12, 124),
            new LinqObj25_36("Fsdfweewher", 21314.52, 125),
            new LinqObj25_36("Dbdfbdfb", 234.12, 126),
            new LinqObj25_36("Csdvdsverb", 5673.25, 127),
            new LinqObj25_36("Kjethhdfg", 23423.46, 128),
            new LinqObj25_36("Lfgnfgn", 7457.45, 129),
            new LinqObj25_36("Phkjghj", 34547.34, 130),
            new LinqObj25_36("Pgjmnbm", 34524.64, 131),
            new LinqObj25_36("Ibnmhj", 4363.34, 132),
            new LinqObj25_36("Ihjghnbm", 346.34, 133),
            new LinqObj25_36("Kfgmghm", 3474.76, 134),
            new LinqObj25_36("Igghmm", 345345.34, 135),
            new LinqObj25_36("Yhjhj", 0, 136),
            new LinqObj25_36("Hgjghm", 345.34, 137),
            new LinqObj25_36("Ofghmghm", 75467.34, 138),
            new LinqObj25_36("Hfhmgh", 6346.45, 139),
            new LinqObj25_36("Ifhjmghm", 0, 140),
            new LinqObj25_36("Gsdvsdv", 34634.35, 141),
            new LinqObj25_36("Grehhth", 6346.35, 142),
            new LinqObj25_36("Vdrbrb", 0, 143),
            new LinqObj25_36("Tesdv", 34634.34, 144),
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
        private void LinqObj25()
        {
            Console.WriteLine("LinqObj25");
            var result = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, porch = Math.Truncate((double)(x.FlatNum-1)/36 + 1)})
                .GroupBy(x => x.porch,
                (k, g) => new { k, allDebt = g.Sum(x => x.Debt)})
                .OrderBy(x => x.allDebt)
                .Last();
            Console.WriteLine($"{result.k},{result.allDebt}");
        }
        private void LinqObj26()
        {
            Console.WriteLine("LinqObj26");
            var results = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, porch = Math.Truncate((double)(x.FlatNum - 1) / 36 + 1) })
                .Where(x => x.Debt != 0)
                .GroupBy(x => x.porch,
                (k, g) => new { k, count = g.Count(), srZn = g.Sum(x => x.Debt)/g.Count() })
                .OrderBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k},{result.count},{result.srZn}");
            }
        }
        private void LinqObj27()
        {
            Console.WriteLine("LinqObj27");
            var results = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, Floor = Math.Truncate((double)(x.FlatNum - 1) / 16 + 1) })
                .Where(x => x.Debt != 0)
                .GroupBy(x => x.Floor,
                (k, g) => new { k, count = g.Count(), srZn = g.Sum(x => x.Debt) / g.Count() })
                .OrderBy(x => x.count)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k},{result.count},{result.srZn}");
            }
        }
        private void LinqObj28()
        {
            Console.WriteLine("LinqObj28");
            var results = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, Floor = Math.Truncate((double)(x.FlatNum - 1) / 16 + 1) })
                .Where(x => x.Debt != 0)
                .GroupBy(x => x.Floor,
                (k, g) => new { k, count = g.Count(), srZn = g.Sum(x => x.Debt) / g.Count() })
                .OrderByDescending(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k},{result.count},{result.srZn}");
            }
        }
        private void LinqObj29()
        {
            Console.WriteLine("LinqObj29");
            var results = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, porch = Math.Truncate((double)(x.FlatNum - 1) / 36 + 1) })
                .Where(x => x.Debt != 0)
                .GroupBy(x => x.porch,
                (k, g) => new { inf = g.OrderBy(x => x.Debt).Last()})
                .OrderBy(x => x.inf.porch);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.inf.porch},{result.inf.FlatNum},{result.inf.Surname},{result.inf.Debt}");
            }
        }
        private void LinqObj30()
        {
            Console.WriteLine("LinqObj30");
            var results = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, Floor = Math.Truncate((double)(x.FlatNum - 1) / 16 + 1) })
                .Where(x => x.Debt != 0)
                .GroupBy(x => x.Floor,
                (k, g) => new { inf = g.OrderByDescending(x => x.Debt).Last() })
                .OrderBy(x => x.inf.Floor);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.inf.FlatNum},{result.inf.Floor},{result.inf.Surname},{result.inf.Debt}");
            }
        }
        private void LinqObj31()
        {
            Console.WriteLine("LinqObj31");
            var results = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, porch = Math.Truncate((double)(x.FlatNum - 1) / 36 + 1) })
                .Where(x => x.Debt != 0)
                .GroupBy(x => x.porch,
                (k, g) => new { inf = g.OrderByDescending(x => x.Debt).Take(3) })
                .SelectMany(x => x.inf)
                .OrderBy(x => x.Debt);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Debt},{result.porch},{result.FlatNum},{result.Surname}");
            }
        }
        private void LinqObj32()
        {
            Console.WriteLine("LinqObj32");
            var results = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, Floor = Math.Truncate((double)(x.FlatNum - 1) / 16 + 1) })
                .GroupBy(x => x.Floor,
                (k, g) => new { inf = g.Where(x => x.Debt != 0).Count() == 0 ? g.First() : g.Where(x => x.Debt != 0).OrderByDescending(x => x.Debt).Last() })
                .Select(x => x.inf)
                .OrderBy(x => x.Floor);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Floor},{result.Debt}");
            }
        }
        private void LinqObj33()
        {
            Console.WriteLine("LinqObj33");
            var average = linqObj25_36.Where(y => y.Debt != 0).Average(y => y.Debt);
            var results = linqObj25_36.Where(x => x.Debt != 0)
                .Where(x => x.Debt >= average)
                .OrderBy(x => x.FlatNum);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.FlatNum},{result.Surname},{result.Debt}");
            }
        }
        private void LinqObj34()
        {
            Console.WriteLine("LinqObj34");
            var average = linqObj25_36.Where(y => y.Debt != 0).Average(y => y.Debt);
            var results = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, Floor = Math.Truncate((double)(x.FlatNum - 1) / 16 + 1) })
                .Where(x => x.Debt != 0)
                .Where(x => x.Debt <= average)
                .OrderByDescending(x => x.Floor)
                .ThenBy(x => x.FlatNum);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Floor},{result.FlatNum},{result.Surname},{result.Debt}");
            }
        }
        private void LinqObj35()
        {
            Console.WriteLine("LinqObj35");
        }
        private void LinqObj36()
        {
            Console.WriteLine("LinqObj36");
        }
    }
}
