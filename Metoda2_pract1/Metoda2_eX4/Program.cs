using System;

namespace Metoda2_eX4
{
    class Program
    {
        enum Months { None, Jan, Feb, March, Apr, May, June, july, Aug, Sep, Oct, Nov, Desem };
        enum Seasons { Winter, Spring, Summer, Autumn, None };
        static void Main(string[] args)
        {
            Months month = Months.Feb;
            Seasons season = Seasons.None;
            switch (month)
            {
                case Months.Jan:
                case Months.Feb:
                case Months.Desem: season = Seasons.Winter;
                    break;
                case Months.March:
                case Months.Apr:
                case Months.May: season = Seasons.Spring;
                    break;
                case Months.June:
                case Months.july:
                case Months.Aug: season = Seasons.Summer;
                    break;
                case Months.Sep:
                case Months.Oct:
                case Months.Nov: season = Seasons.Autumn;
                    break;
            }
            Console.WriteLine(season);
            Console.ReadLine();



        }
    }
}
