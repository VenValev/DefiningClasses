using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class DateModifier
    {
        string date1;
        string date2;
        int year1;
        int month1;
        int day1;
        int year2;
        int month2;
        int day2;


        DateModifier(string date1, string date2)
        {
            this.date1 = date1;
            this.date2 = date2;
        }

        public int Year1
        {
            get { return year1; }
            set { year1 = int.Parse(date1.Split(' ')[0]); }
        }
        public int Year2
        {
            get { return year2; }
            set { year2 = int.Parse(date2.Split(' ')[0]); }
        }
        public int Month1
        {
            get { return month1; }
            set { month1 = int.Parse(date1.Split(' ')[0]); }
        }
        public int Month2
        {
            get { return month2; }
            set { month2 = int.Parse(date2.Split(' ')[0]); }
        }
        public int Day1
        {
            get { return day1; }
            set { day1 = int.Parse(date1.Split(' ')[0]); }
        }
        public int Day2
        {
            get { return day2; }
            set { day2 = int.Parse(date2.Split(' ')[0]); }
        }

        public void PrintDifference()
        {
            
        }
    }
}
