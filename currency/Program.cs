using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency
{
    abstract class inr_usd
    {
        public abstract void inrtousd();
    }
    abstract class inr_yen
    {
        public abstract void inrtoyen();
    }
    abstract class inr_euro
    {
        public abstract void inrtoeuro();
    }
    abstract class usd_inr
    {
        public abstract void usdtoinr();
    }
    abstract class yen_inr
    {
        public abstract void yentoinr();
    }
    abstract class euro_inr
    {
        public abstract void eurotoinr();
    }
    class inrtousdconv : inr_usd
    {
        public double inr = Convert.ToDouble(Console.ReadLine());
        public double result = 0;
        public inrtousdconv()
        {
            result = inr * 0.013;
            
        }
        public override void inrtousd()
        {
            Console.WriteLine("INR in USD: " + result);
        }
    }
    class inrtoyenconv : inr_yen
    {
        public double inr = Convert.ToDouble(Console.ReadLine());
        public double result = 0;
        public inrtoyenconv()
        {
            result = inr * 1.54;

        }
        public override void inrtoyen()
        {
            Console.WriteLine("INR in YEN: " + result);
        }
    }
    class inrtoeuroconv : inr_euro
    {
        public double inr = Convert.ToDouble(Console.ReadLine());
        public double result = 0;
        public inrtoeuroconv()
        {
            result = inr * 0.012;

        }
        public override void inrtoeuro()
        {
            Console.WriteLine("INR in Euro: " + result);
        }
    }
    class usdtoinrconv : usd_inr
    {
        public double usd = Convert.ToDouble(Console.ReadLine());
        public double result = 0;
        public usdtoinrconv()
        {
            result = usd * 74.29;

        }
        public override void usdtoinr()
        {
            Console.WriteLine("USD in INR: " + result);
        }
    }
    class yentoinrconv : yen_inr
    {
        public double yen = Convert.ToDouble(Console.ReadLine());
        public double result = 0;
        public yentoinrconv()
        {
            result = yen * 0.65;

        }
        public override void yentoinr()
        {
            Console.WriteLine("YEN in INR: " + result);
        }
    }
    class eurotoinrconv : euro_inr
    {
        public double euro = Convert.ToDouble(Console.ReadLine());
        public double result = 0;
        public eurotoinrconv()
        {
            result = euro * 74.29;

        }
        public override void eurotoinr()
        {
            Console.WriteLine("Euro in INR: " + result);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. INR to USD\n 2. INR to YEN\n 3. INR to Euro\n 4.USD to INR\n 5. YEN to INR\n 6. Euro to INR");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                inr_usd i = new inrtousdconv();
                i.inrtousd();
            }
            else if (choice == 2)
            {
                inr_yen y = new inrtoyenconv();
                y.inrtoyen();
            }
            else if (choice == 3)
            {
                inr_euro y = new inrtoeuroconv();
                y.inrtoeuro();
            }
            else if (choice == 4)
            {
                usd_inr y = new usdtoinrconv();
                y.usdtoinr();
            }
            else if (choice == 5)
            {
                yen_inr y = new yentoinrconv();
                y.yentoinr();
            }
            else if (choice == 6)
            {
                euro_inr y = new eurotoinrconv();
                y.eurotoinr();
            }
        }
    }
}
