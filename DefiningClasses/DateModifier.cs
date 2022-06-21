using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class DateModifier
    {
        string date1;
        string date2;
        DateTime startDate;
        DateTime endDate;

        public DateModifier(string date1, string date2)
        {
            this.Date1 = date1;
            this.Date2 = date2;
            this.StartDate = Convert.ToDateTime(Date1);
            this.EndDate = Convert.ToDateTime(Date2);
            
        }
        
        public string Date1
        {
            get { return date1; }
            set { date1 = value; }
        }
        public string Date2
        {
            get { return date2; }
            set { date2 = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            //set { startDate = DateTime.Parse(Date1); }
            //set { startDate = Convert.ToDateTime(Date1); }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            //set { endDate = Convert.ToDateTime(Date2); }
            //set { endDate = DateTime.Parse(Date2); }
            set { endDate = value; }
        }

        public int ReturningDate()
        {
            //TimeSpan t = DateTime.Parse(Date1) - DateTime.Parse(Date2);
            TimeSpan t = StartDate - EndDate;
            int d = Math.Abs((int)t.TotalDays);
            return d;
        }



    }
}
