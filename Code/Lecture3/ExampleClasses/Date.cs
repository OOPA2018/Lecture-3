using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3.ExampleClasses
{   
    public class Date
    {
        private int day;
        private int month;
        public int Year { get; private set; }

        // Default constructor
        public Date()
        {
            day = 1;
            month = 1;
            Year = 1;
        }
        
        // Copy constructor
        public Date(Date d)
        {
            day = d.day;
            month = d.month;
            Year = d.Year;
        }     
       

        private static bool IsValidDate(int day, int month, int year)
        {
            // do some checks
            //something basic (and not entirely correct!) could be:
            if (day > 0 && day <= 31 && month > 0 && month <= 12 && year > 0)
            {
                return true;
            }
            return false;
        }

        public static Date CreateDate(int day, int month, int year)
        {
            Date d = new Date();
            if (IsValidDate(day, month, year))
            {
                d.day = day; d.month = month; d.Year = year;
                return d;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Invalid date!");
            }                
        }

        public int GetDayOfMonth()
        {
            return day;
        }

        public void SetDayOfMonth(int inputDay)
        {
            if (IsValidDate(inputDay, this.month, this.Year))
            {
                day = inputDay;
            }
            else
                throw new System.ArgumentOutOfRangeException("Invalid date!");
        }
    }
}
