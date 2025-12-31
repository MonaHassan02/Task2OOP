using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2OOPLibrary
{
    public struct HireDate : IComparable<HireDate>
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            if (day < 1 || day > 31)
            {
                Console.WriteLine("Day must be between 1 and 31");
                day = 1;
            }

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Month must be between 1 and 12");
                month = 1;
            }

            if (year < 1900 || year > DateTime.Now.Year)
            {
                Console.WriteLine("Year must be between 1900 and {DateTime.Now.Year}");
                year = 2000;
            }
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
        public int CompareTo(HireDate other)
        {
            if (Year != other.Year)
            {
                return Year.CompareTo(other.Year);
            }

            if (Month != other.Month)
            {
                return Month.CompareTo(other.Month);
            }

            return Day.CompareTo(other.Day);
        }
    }
}
