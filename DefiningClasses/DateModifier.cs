using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class DateModifier
    {
        string date1;
        string date2;
        DateTime d1;
        DateTime d2;

        public DateModifier(string date1, string date2)
        {
            this.date1 = date1;
            this.date2 = date2;
        }
        
        public string Date1
        {
            get { return date1; }
            set { date1 = value; }
        }
        public string Date2
        {
            get { return date2; }
            set { date1 = value; }
        }
        public DateTime StartDate
        {
            get { return d1; }
            set { d1 = DateTime.Parse(Date1); }
        }
        public DateTime EndDate
        {
            get { return d1; }
            set { d1 = DateTime.Parse(Date2); }
        }

        public int ReturningDate(DateTime StartDate, DateTime EndDate)
        {
            TimeSpan t = StartDate - StartDate;
            int d = Math.Abs((int)t.TotalDays);
            return d;
        }



    }
}
