﻿using System;
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
            //met1_12();
            //met13_24();
            //met25_36();
            //met37_48();
            met49_60();
        }
        private void met1_12()
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
        private void met13_24()
        {
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
        private void met25_36()
        {
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
        private void met37_48()
        {
            LinqObj37();
            LinqObj38();
            LinqObj39();
            LinqObj40();
            LinqObj41();
            LinqObj42();
            LinqObj43();
            LinqObj44();
            LinqObj45();
            LinqObj46();
            LinqObj47();
            LinqObj48();
        }
        private void met49_60()
        {
            LinqObj49();
            LinqObj50();
            LinqObj51();
            LinqObj52();
            LinqObj53();
            LinqObj54();
            LinqObj55();
            LinqObj56();
            LinqObj57();
            LinqObj58();
            LinqObj59();
            LinqObj60();
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
                this.Surname = Surname;
                this.Debt = Debt;
                this.FlatNum = FlatNum;
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
        class LinqObj37_48
        {
            public LinqObj37_48(string Company, string Street, double Price, int Brand)
            {
                this.Company = Company;
                this.Street = Street;
                this.Price = Price;
                this.Brand = Brand;
            }
            public string Company { get; set; }
            public string Street { get; set; }
            public double Price { get; set; }
            public int Brand { get; set; }
        }
        private List<LinqObj37_48> linqObj37_48 = new List<LinqObj37_48>
        {
            new LinqObj37_48("ABK", "First", 26.56, 95),
            new LinqObj37_48("ABK", "First", 28.12, 98),

            new LinqObj37_48("ABK", "Second", 25.54, 92),
            new LinqObj37_48("ABK", "Second", 26.47, 95),
            new LinqObj37_48("ABK", "Second", 27.98, 98),

            new LinqObj37_48("ABK", "Third", 25.43, 92),
            new LinqObj37_48("ABK", "Third", 28.43, 98),

            new LinqObj37_48("ABK", "Fourth", 26.38, 92),
            new LinqObj37_48("ABK", "Fourth", 27.23, 95),

            new LinqObj37_48("ABK", "Fifth", 24.98, 92),
            new LinqObj37_48("ABK", "Fifth", 27.71, 98),

            new LinqObj37_48("LOL", "First", 25.21, 92),
            new LinqObj37_48("LOL", "First", 26.42, 95),
            new LinqObj37_48("LOL", "First", 28.24, 98),

            new LinqObj37_48("LOL", "Second", 25.61, 92),
            new LinqObj37_48("LOL", "Second", 26.65, 95),
            new LinqObj37_48("LOL", "Second", 28.01, 98),
            
            new LinqObj37_48("LOL", "Third", 26.75, 95),

            new LinqObj37_48("LOL", "Fourth", 25.99, 92),
            new LinqObj37_48("LOL", "Fourth", 27.12, 95),
            new LinqObj37_48("LOL", "Fourth", 28.67, 98),

            new LinqObj37_48("LOL", "Fifth", 24.79, 92),
            new LinqObj37_48("LOL", "Fifth", 27.80, 98),

            new LinqObj37_48("Kyiv", "First", 25.33, 92),
            new LinqObj37_48("Kyiv", "First", 26.34, 95),
            new LinqObj37_48("Kyiv", "First", 28.35, 98),

            new LinqObj37_48("Kyiv", "Second", 25.41, 92),
            new LinqObj37_48("Kyiv", "Second", 26.53, 95),
            new LinqObj37_48("Kyiv", "Second", 28.31, 98),

            new LinqObj37_48("Kyiv", "Third", 25.13, 92),
            new LinqObj37_48("Kyiv", "Third", 28.04, 98),

            new LinqObj37_48("Kyiv", "Fourth", 26.76, 92),
            new LinqObj37_48("Kyiv", "Fourth", 27.13, 95),

            new LinqObj37_48("Kyiv", "Fifth", 25.11, 92),
            new LinqObj37_48("Kyiv", "Fifth", 26.03, 95),
            new LinqObj37_48("Kyiv", "Fifth", 28.02, 98),
            
            new LinqObj37_48("LongName", "First", 26.25, 95),
            new LinqObj37_48("LongName", "First", 28.19, 98),

            new LinqObj37_48("LongName", "Second", 25.56, 92),
            new LinqObj37_48("LongName", "Second", 26.34, 95),
            new LinqObj37_48("LongName", "Second", 28.32, 98),

            new LinqObj37_48("LongName", "Third", 25.32, 92),
            new LinqObj37_48("LongName", "Third", 26.43, 95),
            new LinqObj37_48("LongName", "Third", 28.54, 98),

            new LinqObj37_48("LongName", "Fourth", 26.21, 92),
            new LinqObj37_48("LongName", "Fourth", 27.71, 98),

            new LinqObj37_48("LongName", "Fifth", 25.12, 92),
            new LinqObj37_48("LongName", "Fifth", 25.81, 95),
            new LinqObj37_48("LongName", "Fifth", 28.79, 98),

            new LinqObj37_48("Interes", "First", 25.23, 92),
            new LinqObj37_48("Interes", "First", 26.31, 95),
            new LinqObj37_48("Interes", "First", 28.33, 98),
            
            new LinqObj37_48("Interes", "Second", 26.34, 95),
            new LinqObj37_48("Interes", "Second", 28.54, 98),

            new LinqObj37_48("Interes", "Third", 25.34, 92),
            new LinqObj37_48("Interes", "Third", 26.57, 95),
            new LinqObj37_48("Interes", "Third", 28.57, 98),

            new LinqObj37_48("Interes", "Fourth", 25.78, 92),
            new LinqObj37_48("Interes", "Fourth", 27.32, 95),
            new LinqObj37_48("Interes", "Fourth", 29.21, 98),

            new LinqObj37_48("Interes", "Fifth", 25.01, 92),
            new LinqObj37_48("Interes", "Fifth", 27.99, 98),
        };

        class LinqObj49_60
        {
            public LinqObj49_60(string Surname, string Initials, int SchoolNumber, string EGE)
            {
                this.Surname = Surname;
                this.Initials = Initials;
                this.SchoolNumber = SchoolNumber;
                this.EGE = EGE;
            }
            public string Surname { get; set; }
            public string Initials { get; set; }
            public int SchoolNumber { get; set; }
            public string EGE { get; set; }
        }

        private List<LinqObj49_60> linqObj49_60 = new List<LinqObj49_60>
        {
            new LinqObj49_60("Qfwefwe", "Q.F.K.", 42, "24 42 76"),
            new LinqObj49_60("Gsdfsd", "G.W.H.", 52, "64 39 85"),
            new LinqObj49_60("Fsdf", "F.G.W.", 45, "24 85 23"),
            new LinqObj49_60("Nfrgr", "N.F.J.", 45, "43 23 65"),
            new LinqObj49_60("LGdfgr", "L.F.E.", 42, "23 65 98"),
            new LinqObj49_60("Hfdge", "H.E.Y.", 26, "95 34 65"),
            new LinqObj49_60("Lsdgsgse", "L.B.Y.", 65, "32 65 76"),
            new LinqObj49_60("Owef", "O.E.Q.", 75, "34 67 84"),
            new LinqObj49_60("Pdfgknrg", "Pgref", 57, "34 45 76"),
            new LinqObj49_60("Psdfec", "P.G.W.", 75, "34 65 3"),
            new LinqObj49_60("Pdfbvbr", "P.N.J.", 75, "54 56 23"),
            new LinqObj49_60("Obfbqx", "O.K.L.", 34, "54 67 90"),
            new LinqObj49_60("Kbfgnw", "K.L.O.", 24, "34 87 98"),
            new LinqObj49_60("Kngfhnt", "K.R.W.", 98, "45 87 39"),
            new LinqObj49_60("Jodgfmrn", "J.N.M.", 68, "59 86 90"),
            new LinqObj49_60("Jnmwer", "J.N.M.", 68, "45 97 83"),
            new LinqObj49_60("Ymvld", "Y.I.B.", 68, "45 86 83"),
            new LinqObj49_60("First", "F.H.T.", 31, "75 41 94"),
            new LinqObj49_60("Second", "S.L.J.", 31, "39 64 94"),
            new LinqObj49_60("First", "F.L.R.", 32, "41 65 85"),
            new LinqObj49_60("Second", "S.U.L.", 32, "45 86 85"),
            new LinqObj49_60("Kgerg", "K.W.L.", 75, "49 48 43"),
            new LinqObj49_60("Fwefe", "F.B.M.", 29, "47 49 39"),
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
            var results = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, porch = Math.Truncate((double)(x.FlatNum - 1) / 36 + 1) })
                .Where(x => x.Debt != 0)
                .GroupBy(x => x.porch,
                (k, g) => new { inf = g.Where(x => x.Debt < g.Average(y => y.Debt)) })
                .SelectMany(x => x.inf)
                .OrderBy(x => x.porch)
                .ThenByDescending(x => x.Debt);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.porch},{result.Debt},{result.Surname},{result.FlatNum}");
            }
        }
        private void LinqObj36()
        {
            Console.WriteLine("LinqObj36");
            var results = linqObj25_36.Select(x => new { x.Debt, x.FlatNum, x.Surname, Floor = Math.Truncate((double)(x.FlatNum - 1) / 16 + 1) })
                .Where(x => x.Debt != 0)
                .GroupBy(x => x.Floor,
                (k, g) => new { inf = g.Where(x => x.Debt <= g.Average(y => y.Debt)) })
                .SelectMany(x => x.inf)
                .OrderBy(x => x.Floor)
                .ThenBy(x => x.Debt);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Floor},{result.Debt},{result.Surname},{result.FlatNum}");
            }
        }
        private void LinqObj37()
        {
            Console.WriteLine("LinqObj37");
            var results = linqObj37_48.GroupBy(e => e.Brand,
                (k, g) => new { k, min = g.Min(x => x.Price), max = g.Max(x => x.Price) })
                .OrderByDescending(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k}, {result.min}, {result.max}");
            }
        }
        private void LinqObj38()
        {
            Console.WriteLine("LinqObj38");
            var results = linqObj37_48.GroupBy(e => e.Brand,
                (k, g) => new { k, count = g.Count() })
                .OrderBy(x => x.count)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.count}, {result.k}");
            }
        }
        private void LinqObj39()
        {
            Console.WriteLine("LinqObj39");
            var M = 92;
            var results = linqObj37_48.GroupBy(e => e.Street,
                (k, g) => new { k, count = g.Count(x => x.Brand == M) })
                .OrderBy(x => x.count)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.count}, {result.k}");
            }
        }
        private void LinqObj40()
        {
            Console.WriteLine("LinqObj40");
            var results = linqObj37_48.GroupBy(e => e.Street,
                (k, g) => new { k, count92 = g.Count(x => x.Brand == 92), count95 = g.Count(x => x.Brand == 95), count98 = g.Count(x => x.Brand == 98) })
                .OrderBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k}, {result.count92}, {result.count95}, {result.count98}");
            }
        }
        private void LinqObj41() /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        {
            Console.WriteLine("LinqObj41");
            var M = 91;
            //var results = linqObj37_48.GroupBy(e => e.Street,
            //    (k, g) => new { k, max = g.Where(x => x.Brand == M).Count() == 0 ? "No" : g.Where(x => x.Brand == M).Max(x => x.Price).ToString() })
            //    .OrderBy(x => x.max.Where(y => y >= '0' && y <= '9' || y == ',').Count() == x.max.Count() ? Convert.ToDouble(x.max) : 0)
            //    .ThenBy(x => x.k);
            var results = linqObj37_48.Where(x => x.Brand == M)
                .GroupBy(e => e.Street,
                (k, g) => new { k, max = g.Max(x => x.Price) })
                .OrderBy(x => x.max)
                .ThenBy(x => x.k)
                .Select(x => $"{x.max}, {x.k}")
                .DefaultIfEmpty("no");
            foreach (var result in results)
            {
                Console.WriteLine($"{result}");
            }
        }
        private void LinqObj42()
        {
            Console.WriteLine("LinqObj42");
            var results = linqObj37_48.GroupBy(e => e.Street,
                (k, g) => new
                {
                    k,
                    min92 = g.Where(x => x.Brand == 92).Select(x => x.Price).DefaultIfEmpty(0).Min(x => x),
                    min95 = g.Where(x => x.Brand == 95).Select(x => x.Price).DefaultIfEmpty(0).Min(x => x),
                    min98 = g.Where(x => x.Brand == 98).Select(x => x.Price).DefaultIfEmpty(0).Min(x => x),
                })
                .OrderBy(x => x.k);
            //var results = linqObj37_48.GroupBy(e => e.Street,
            //    (k, g) => new
            //    {
            //        k,
            //        min92 = g.Where(x => x.Brand == 91).Count() == 0 ? 0 : g.Where(x => x.Brand == 92).Min(x => x.Price),
            //        min95 = g.Where(x => x.Brand == 95).Count() == 0 ? 0 : g.Where(x => x.Brand == 95).Min(x => x.Price),
            //        min98 = g.Where(x => x.Brand == 98).Count() == 0 ? 0 : g.Where(x => x.Brand == 98).Min(x => x.Price),
            //    })
            //    .OrderBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k}, {result.min92}, {result.min95}, {result.min98}");
            }
        }
        private void LinqObj43()
        {
            Console.WriteLine("LinqObj43");
            var M = 95;
            var results = linqObj37_48.GroupBy(e => e.Company,
                (k, g) => new {
                    k,
                    variation = g.Where(x => x.Brand == M).Count() == 0 
                    ? -1 
                    : g.Where(x => x.Brand == M).Max(x => x.Price) - g.Where(x => x.Brand == M).Min(x => x.Price)
                })
                .OrderByDescending(x => x.variation)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.variation}, {result.k}");
            }
        }
        private void LinqObj44()
        {
            Console.WriteLine("LinqObj44");
            var results = linqObj37_48.GroupBy(e => e.Company,
                (k, g) => new {
                    k,
                    variation92 = g.Where(x => x.Brand == 92).Count() == 0
                    ? -1
                    : g.Where(x => x.Brand == 92).Max(x => x.Price) - g.Where(x => x.Brand == 92).Min(x => x.Price),
                    variation95 = g.Where(x => x.Brand == 95).Count() == 0
                    ? -1
                    : g.Where(x => x.Brand == 95).Max(x => x.Price) - g.Where(x => x.Brand == 95).Min(x => x.Price),
                    variation98 = g.Where(x => x.Brand == 98).Count() == 0
                    ? -1
                    : g.Where(x => x.Brand == 98).Max(x => x.Price) - g.Where(x => x.Brand == 98).Min(x => x.Price)
                })
                .OrderBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k}, {result.variation92}, {result.variation95}, {result.variation98}");
            }
        }
        private void LinqObj45()
        {
            Console.WriteLine("LinqObj45");
            var results = linqObj37_48.GroupBy(e => new { e.Street, e.Company },
                (k, g) => k)
                .GroupBy(e => e.Street,
                (k, g) => new { k, count = g.Count()})
                .OrderBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k}, {result.count}");
            }
        }
        private void LinqObj46()
        {
            Console.WriteLine("LinqObj46");
            var results = linqObj37_48.GroupBy(e => new { e.Company, e.Street },
                (k, g) => new {k, g})
                .GroupBy(e => e.k.Company,
                (k, g) => new {k,
                    count = g.Count(x => 
                    x.g.Select(y => y.Brand).Contains(92) 
                    && x.g.Select(y => y.Brand).Contains(95) 
                    && x.g.Select(y => y.Brand).Contains(98)) })
                .OrderByDescending(x => x.count)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.count}, {result.k}");
            }
        }
        private void LinqObj47()
        {
            Console.WriteLine("LinqObj47");
            var results = linqObj37_48.GroupBy(e => new { e.Company, e.Street },
                (k, g) => new { k, count = g.Count() })
                .Where(x => x.count >= 2)
                .OrderBy(x => x.k.Company)
                .ThenBy(x => x.k.Street)
                .Select(x => $"{x.k.Company}, {x.k.Street}, {x.count}")
                .DefaultIfEmpty("No");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
        private void LinqObj48()
        {
            Console.WriteLine("LinqObj48");
            var results = linqObj37_48.SelectMany(x => linqObj37_48.Select(y => new { x.Street, y.Company}))
                .Distinct()
                .GroupJoin(linqObj37_48.Select(x => new { x.Brand, x.Company, x.Street}),
                x => new { x.Company, x.Street },
                y => new { y.Company, y.Street},
                (k, g) => new { k, count = g.Count()})
                .OrderBy(x => x.k.Street)
                .ThenBy(x => x.k.Company);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k.Street}, {result.k.Company}, {result.count}");
            }
        }
        private void LinqObj49()
        {
            Console.WriteLine("LinqObj49");
            var min = linqObj49_60.Select(x => 
            new {sum = x.EGE.Split(' ').Sum(y => Convert.ToInt32(y))})
                .Min(x => x.sum);
            var results = linqObj49_60.Select(x => 
            new {x.Initials,
                x.SchoolNumber,
                x.Surname,
                sum = Convert.ToInt32(x.EGE.Split(' ')[0]) 
                + Convert.ToInt32(x.EGE.Split(' ')[1]) 
                + Convert.ToInt32(x.EGE.Split(' ')[2]) })
                .Where(x => x.sum == min);
            Console.WriteLine(min);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Surname}, {result.Initials}, {result.SchoolNumber}");
            }
        }
        private void LinqObj50()
        {
            Console.WriteLine("LinqObj50");
            var maxTwo = linqObj49_60.Select(x =>
            new { sum = x.EGE.Split(' ').Sum(y => Convert.ToInt32(y)) })
                .OrderByDescending(x => x.sum)
                .Take(2)
                .Select(x => x.sum);
            var results = linqObj49_60.Select(x =>
            new {
                x.Initials,
                x.SchoolNumber,
                x.Surname,
                sum = Convert.ToInt32(x.EGE.Split(' ')[0])
                + Convert.ToInt32(x.EGE.Split(' ')[1])
                + Convert.ToInt32(x.EGE.Split(' ')[2])
            })
                .Where(x => x.sum == maxTwo.First() || x.sum == maxTwo.Last());
            Console.WriteLine(maxTwo.First());
            Console.WriteLine(maxTwo.Last());
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Surname}, {result.Initials}, {result.SchoolNumber}");
            }
        }
        private void LinqObj51()
        {
            Console.WriteLine("LinqObj51");
            var results = linqObj49_60.GroupBy(e => e.SchoolNumber,
                (k, g) => new { student = g.OrderByDescending(x => Convert.ToInt32(x.EGE.Split(' ')[2])).First()})
                .Select(x => x.student)
                .OrderBy(x => x.SchoolNumber);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.SchoolNumber}, {result.Surname}, {result.Initials}, {result.EGE.Split(' ')[2]}");
            }
        }
        private void LinqObj52()
        {
            Console.WriteLine("LinqObj52");
            var results = linqObj49_60.GroupBy(e => e.SchoolNumber,
                (k, g) => new { student = 
                g.OrderBy(x => (x.EGE.Split(' ')
                .Sum(y => Convert.ToInt32(y))))
                .ThenBy(x => x.Surname)
                .ThenBy(x => x.Initials)
                .First() })
                .Select(x => x.student)
                .OrderByDescending(x => x.SchoolNumber);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.SchoolNumber}," +
                    $"{result.EGE.Split(' ').Sum(y => Convert.ToInt32(y))}," +
                    $"{result.Surname}," +
                    $"{result.Initials}");
            }
        }
        private void LinqObj53()
        {
            Console.WriteLine("LinqObj53");
            var results = linqObj49_60.GroupBy(e => e.SchoolNumber,
                (k, g) => new {k, count = g.Count(x => (x.EGE.Split(' ').Sum(y => Convert.ToInt32(y))) > 150) })
                .OrderByDescending(x => x.count)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.count}, {result.k}");
            }
        }
        private void LinqObj54()
        {
            Console.WriteLine("LinqObj54");
            var results = linqObj49_60.GroupBy(e => e.SchoolNumber,
                (k, g) => new { k, average = Convert.ToInt32(g.Average(x => (x.EGE.Split(' ').Sum(y => Convert.ToInt32(y))))) })
                .OrderByDescending(x => x.average)
                .ThenBy(x => x.k);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.average}, {result.k}");
            }
        }
        private void LinqObj55()
        {
            Console.WriteLine("LinqObj55");
            var results = linqObj49_60.Where(x => x.EGE.Split(' ').All(y => Convert.ToInt32(y) >= 50))
                .OrderBy(x => x.Surname)
                .ThenBy(x => x.Initials)
                .Select(x => $"{x.Surname}, {x.Initials}, {x.SchoolNumber}, {x.EGE.Split(' ').Sum(y => Convert.ToInt32(y))}")
                .DefaultIfEmpty("Required students not found");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
        private void LinqObj56()
        {
            Console.WriteLine("LinqObj56");
            var results = linqObj49_60.Where(x => x.EGE.Split(' ').Any(y => Convert.ToInt32(y) > 90))
                .OrderBy(x => x.Surname)
                .ThenBy(x => x.Initials)
                .ThenBy(x => x.SchoolNumber)
                .Select(x => $"{x.Surname}, {x.Initials}, {x.SchoolNumber}")
                .DefaultIfEmpty("Required students not found");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
        private void LinqObj57()
        {
            Console.WriteLine("LinqObj57");
            var results = linqObj49_60.GroupBy(e => e.SchoolNumber,
                 (k, g) => new { students = 
                 g.Where(x => x.EGE.Split(' ').All(y => Convert.ToInt32(y) < 50))
                 .OrderBy(x => x.Surname)
                 .ThenBy(x => x.Initials)
                 .Take(3)})
                 .SelectMany(x => x.students)
                .OrderBy(x => x.SchoolNumber)
                .ThenBy(x => x.Surname)
                .ThenBy(x => x.Initials)
                .Select(x => $"{x.SchoolNumber}, {x.Surname}, {x.Initials}")
                .DefaultIfEmpty("Required students not found");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
        private void LinqObj58()
        {
            Console.WriteLine("LinqObj58");
            var results = linqObj49_60.GroupBy(e => e.SchoolNumber,
                 (k, g) => new
                 {
                     k,
                     //l = g.Select(x => x.EGE.Split(' ').Count(y => Convert.ToInt32(y) >= 50)),
                     first = g.Where(x => Convert.ToInt32(x.EGE.Split(' ')[0]) >= 50).Count(),
                     secont = g.Where(x => Convert.ToInt32(x.EGE.Split(' ')[1]) >= 50).Count(),
                     third = g.Where(x => Convert.ToInt32(x.EGE.Split(' ')[2]) >= 50).Count()
                 })
                .OrderBy(x => x.k);
            //foreach (var f in results)
            //{
            //    foreach (var k in f.l)
            //    {
            //        Console.WriteLine(k);
            //    }
            //}
            foreach (var result in results)
            {
                Console.WriteLine($"{result.k}, {result.first}, {result.secont}, {result.third}");
            }
        }
        private void LinqObj59()
        {
            Console.WriteLine("LinqObj59");
        }
        private void LinqObj60()
        {
            Console.WriteLine("LinqObj60");
        }
    }
}
