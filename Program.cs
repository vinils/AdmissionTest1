//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        public static string ChangeDate(string date, char op, long value)
        {
            var positiveValue = (value < 0) ? value * -1 : value;
            var min = ViníciusLourençoSantos.Minute.Parse(positiveValue.ToString());
            var dt = ViníciusLourençoSantos.Date.Parse(date);

            switch (op)
            {
                case '+':
                    return dt + min;
                case '-':
                    return dt - min;
                default:
                    throw new Exception("op not reconized");
            }
        }

        static void Main(string[] args)
        {
            var test = ChangeDate("01/03/2010 23:00", '+', 4000);
            var test2 = ChangeDate("01/03/2010 23:00", '-', 4000);

            var dateTest = new ViníciusLourençoSantos.DateTest();
            dateTest.StringDate_WhenParsed_ShouldBeTheSame();
            dateTest.Date_WhenAdded_ShouldWork();
            dateTest.Date_WhenSubtracted_ShouldWork();

            var minuteTest = new ViníciusLourençoSantos.MinuteTest();
            minuteTest.StringMinute_WhenParsedToMinute_ShouldBeTheSame();
            minuteTest.StringMinutes_WhenParsedToDays_ShouldBeConverted();
            minuteTest.StringMinutes_WhenParsedToHour_ShouldBeConverted();
            minuteTest.StringMinutes_WhenParsedToMonth_ShouldBeConverted();
            minuteTest.StringMinutes_WhenParsedToYear_ShouldBeConverted();

            var hourTest = new ViníciusLourençoSantos.HourTest();
            hourTest.Hour_WhenParsedToMinutes_ShouldBeConverted();

            var dayTest = new ViníciusLourençoSantos.DayTest();
            dayTest.Day_WhenParsedToMinutes_ShouldBeConverted();

            var monthTest = new ViníciusLourençoSantos.MonthTest();
            monthTest.Month_WhenParsedToMinutes_ShouldBeConverted();

            var yearTest = new ViníciusLourençoSantos.YearTest();
            yearTest.Year_WhenParsedToMinutes_ShouldBeConverted();
        }
    }
}