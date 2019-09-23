using System;

namespace Lab_1
{
    class Money
    {
        private long rub;
        private uint kop;
        private long rub2;
        private uint kop2;
        private float num;
        private long sum;
        private uint sum2;
        private long sub;
        private uint sub2;
        private long div;
        private long div2;
        private float div3;
        private long divr;
        private uint divr2;
        private long mult;
        private uint mult2;
        private long mult3;
        private float mult4;
        private long comr;
        private long comr2;
        
        public Money()
        {
            rub = 0;
            kop = 0;
            rub2 = 0;
            kop2 = 0;
            num = 0;
            sum = 0;
            sum2 = 0;
            sub = 0;
            sub2 = 0;
            div = 0;
            div2 = 0;
            div3 = 0;
            divr = 0;
            divr2 = 0;
            mult = 0;
            mult2 = 0;
            mult3 = 0;
            mult4 = 0;
            comr = 0;
            comr2 = 0;
        }

        public long Rub { get { return rub; } set { if (value >= 0) rub = value; else Console.WriteLine("Must be positive number!"); } }

        public uint Kop { get { return kop; } set { kop = value; } }
        public long Rub2 { get { return rub2; } set { if (value >= 0) rub2 = value; else Console.WriteLine("Must be positive number!"); } }
        public uint Kop2 { get { return kop2; } set { kop2 = value; } }

        public float Num { get { return num; } set { num = value; } }
        private void print(long a, uint b)
        {
            if (b < 10)
            {
                Console.WriteLine("{0},0{1}", a, b);
            }
            else
                Console.WriteLine("{0},{1}", a, b);
        }

        private long tosum(long a, uint b)
        {
            long c;
            c = a * 100 + b;
            return c;
        }
        public void sumf()
        {
            Console.Write("{0},{1}+{2},{3}=", rub, kop, rub2, kop2);
            sum = rub + rub2;
            sum2 = kop + kop2;
            if(sum2>=100)
            {
                sum++;
                sum2 = sum2 - 100;
            }
            print(sum, sum2);
        }

        public void subf()
        {
            Console.Write("{0},{1}-{2},{3}=", rub, kop, rub2, kop2);
            sub = rub - rub2;
            if (kop2 > kop)
            {
                sub--;
                sub2 = kop + 100 - kop2;
            }
            else
                sub2 = kop - kop2;
            print(sub, sub2);
        }

        public void divf()
        {
            Console.Write("{0},{1}/{2},{3}=", rub, kop, rub2, kop2);
            div = tosum(rub,kop);
            div2 = tosum(rub2,kop2);
            div3 = (float)div / div2;
            Console.WriteLine(div3);
        }

        public void divf2()
        {
            Console.Write("{0},{1}/{2}=", rub, kop,num);
            div3 = tosum(rub,kop);
            div3 = div3 / num;
            div = (int)div3;
            divr = div / 100;
            divr2 = (uint)div % 100;
            print(divr, divr2);
        }

        public void multf()
        {
            Console.Write("{0},{1}*{2}=", rub, kop, num);
            mult3 = tosum(rub, kop);
            mult4 = mult3 * num;
            mult = (int)mult4 / 100;
            mult2 = (uint)mult4 % 100;
            print(mult, mult2);
        }
        public void compf()
        {
            comr = tosum(rub, kop);
            comr2 = tosum(rub2, kop2);
            if (comr == comr2)
                Console.WriteLine("{0},{1}=={2},{3}", rub, kop, rub2, kop2);
            else
                if(comr>comr2)
                    Console.WriteLine("{0},{1}>{2},{3}", rub, kop, rub2, kop2);
                else
                    Console.WriteLine("{0},{1}<{2},{3}", rub, kop, rub2, kop2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nikolajs Razins 4801BD");
            Console.WriteLine(DateTime.Now);
            Money money1 = new Money();
            Console.WriteLine("********FIRST SUM********");
            Console.Write("Enter rubles: ");
            money1.Rub = int.Parse(Console.ReadLine());
            Console.Write("Enter copeck: ");
            money1.Kop = uint.Parse(Console.ReadLine());
            Console.WriteLine("********SECOND SUM********");
            Console.Write("Enter rubles: ");
            money1.Rub2 = int.Parse(Console.ReadLine());
            Console.Write("Enter copeck: ");
            money1.Kop2 = uint.Parse(Console.ReadLine());
            Console.WriteLine("********FRACTIONAL NUMBER********");
            Console.Write("Enter fractional number: ");
            money1.Num = float.Parse(Console.ReadLine());
            money1.sumf();
            money1.subf();
            money1.divf();
            money1.divf2();
            money1.multf();
            money1.compf();
            Console.WriteLine("Press Enter...");
            Console.ReadKey();

        }
    }
}
