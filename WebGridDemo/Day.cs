using System;

namespace WebGridDemo
{
    /// <summary>
    /// Date styles
    /// </summary>
    public enum Dstyle
    {
        monthDay,
        otherDay,
        today
    }

    /// <summary>
    /// Days of the Week
    /// </summary>
    public enum Ddow
    {
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun
    }

    /// <summary>
    /// Months of The Year
    /// </summary>
    public enum Dmoy
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    /// <summary>
    /// Calendar Day
    /// </summary>
    public class Day
    {
        public int DOM { get; set; }
        public DateTime MonthDate { get; set; }
        public Dstyle DayStyle { get; set; }
    }
}