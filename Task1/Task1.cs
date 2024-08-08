using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d3.Task1
{
    public class Task1
    {
        public enum Weekday
        {
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday, 
            Sunday
        }
        public string DayOfWeek(Weekday weekday)
        {
            switch (weekday)
            {
                case Weekday.Monday:
                case Weekday.Tuesday:
                case Weekday.Wednesday:
                case Weekday.Thursday:
                case Weekday.Friday:
                    return $"{weekday} - будний день";
                case Weekday.Saturday:
                case Weekday.Sunday:
                    return $"{weekday} - выходной";
                default:
                    return $"Eror Day";
            }

        }
    }
}
