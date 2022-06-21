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
    }
}
