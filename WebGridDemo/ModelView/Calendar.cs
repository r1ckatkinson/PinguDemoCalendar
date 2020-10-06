using System.Collections.Generic;

namespace WebGridDemo.ModelView
{
    public class Calendar
    {
        public string MonthName { get; set; }
        public IList<Day> MonthDays { get; set; }
    }
}