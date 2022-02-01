using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency
{
    abstract class hr_min
    {
        public abstract void hrtomin();
    }
    abstract class min_hr
    {
        public abstract void mintohr();
    }
    abstract class hr_sec
    {
        public abstract void hrtosec();
    }
    abstract class sec_hr
    {
        public abstract void sectohr();
    }
    class hrtominconv : hr_min
    {
        public double hr = Convert.ToDouble(Console.ReadLine());
        public double result = 0;
        public hrtominconv()
        {
            result = hr * 60;

        }
        public override void hrtomin()
        {
            Console.WriteLine("Hour in Minutes: " + result);
        }
    }
    class mintohrconv : min_hr
    {
        public double min = Convert.ToDouble(Console.ReadLine());
        public double result = 0;
        public mintohrconv()
        {
            result = min / 60;

        }
        public override void mintohr()
        {
            Console.WriteLine("Minutes in Hours: " + result);
        }
    }
    class hrtosecconv : hr_sec
    {
        public double hr = Convert.ToDouble(Console.ReadLine());
        public double result = 0;
        public hrtosecconv()
        {
            result = hr * 3600;

        }
        public override void hrtosec()
        {
            Console.WriteLine("Hour in seconds: " + result);
        }
    }
    class sectohrconv : sec_hr
    {
        public double sec = Convert.ToDouble(Console.ReadLine());
        public double result = 0;
        public sectohrconv()
        {
            result = sec / 3600;

        }
        public override void sectohr()
        {
            Console.WriteLine("Seconds in hour: " + result);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Hour to Minutes\n 2. Minutes to Hour\n 3. Hour to seconds\n 4.Seconds to Hour\n");


            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                hr_min i = new hrtominconv();
                i.hrtomin();
            }
            else if (choice == 2)
            {
                min_hr y = new mintohrconv();
                y.mintohr();
            }
            else if (choice == 3)
            {
                hr_sec y = new hrtosecconv();
                y.hrtosec();
            }
            else if (choice == 4)
            {
                sec_hr y = new sectohrconv();
                y.sectohr();
            }
        }
    }
}
