using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    class WeekDay
    {
        //fields
        private int dayNumber;
        private int year;
        private int month;

        //properties

        public int DayNumber
        {
            get { return this.dayNumber; }
            set { this.dayNumber = value; }
        }


        public int Month
        {
            get { return this.month; }
            set { this.month = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        //constructors

        public WeekDay()
        {
            //default constructor
        }

        public WeekDay(int yearWD, int monthWD, int dayWD)
        {
            this.year = yearWD;
            this.month = monthWD;
            this.dayNumber = dayWD;
        }
        public WeekDay(int dayNumberWD)
        {
            this.dayNumber = dayNumberWD;
        }

        public string GetWeekDay()
        {
            DateTime dt = new DateTime(this.Year, this.Month, this.DayNumber);
            string returnDay = dt.ToString("dddd");
            return returnDay;
        }
        public string GetWeekDaySwitch()
        {
            string weekOfDay;
            switch (this.dayNumber)
            {
                case 1:
                    weekOfDay = "Monday";
                    return weekOfDay;
                case 2:
                    weekOfDay = "Tuesday";
                    return weekOfDay;
                case 3:
                    weekOfDay = "Wednesday";
                    return weekOfDay;
                case 4:
                    weekOfDay = "Thurday";
                    return weekOfDay;
                case 5:
                    weekOfDay = "Friday";
                    return weekOfDay;
                case 6:
                    weekOfDay = "Saturday";
                    return weekOfDay;
                case 7:
                    weekOfDay = "Sunday";
                    return weekOfDay;
                default:
                    weekOfDay = "Happy Day";
                    return weekOfDay;
            }
        }
    }
}
