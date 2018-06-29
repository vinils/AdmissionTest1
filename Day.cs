//-----------------------------------------------------------------------
// <copyright file="Day.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;

    /// <summary>
    /// Day class
    /// </summary>
    public class Day : DateUnit
    {
        /// <summary>
        /// Hours of one day
        /// </summary>
        public const UInt16 Hours = 24;
        
        /// <summary>
        /// Length of the string
        /// </summary>
        public const UInt16 Length = 2;

        /// <summary>
        /// Initializes a new instance of the <see cref="Day"/> class
        /// </summary>
        /// <param name="days">number of days</param>
        public Day(long days)
            : base(days, Length)
        {
        }

        /// <summary>
        /// Implicit cast of Day to Year
        /// </summary>
        /// <param name="day">day class</param>
        /// <returns>Year class</returns>
        public static implicit operator Year(Day day)
        {
            return new Year(day.Number / Year.Days);
        }

        /// <summary>
        /// Implicit cast of Day to Month
        /// </summary>
        /// <param name="day">day class</param>
        /// <returns>Year class</returns>
        public static implicit operator Month(Day day)
        {
            long month;

            if (day.Number >= Month.DaysInMonths[11])
            {
                month = 12;
            }
            else if (day.Number >= Month.DaysInMonths[10])
            {
                month = 11;
            }
            else if (day.Number >= Month.DaysInMonths[9])
            {
                month = 10;
            }
            else if (day.Number >= Month.DaysInMonths[8])
            {
                month = 9;
            }
            else if (day.Number >= Month.DaysInMonths[7])
            {
                month = 8;
            }
            else if (day.Number >= Month.DaysInMonths[6])
            {
                month = 7;
            }
            else if (day.Number >= Month.DaysInMonths[5])
            {
                month = 6;
            }
            else if (day.Number >= Month.DaysInMonths[4])
            {
                month = 5;
            }
            else if (day.Number >= Month.DaysInMonths[3])
            {
                month = 4;
            }
            else if (day.Number >= Month.DaysInMonths[2])
            {
                month = 3;
            }
            else if (day.Number >= Month.DaysInMonths[1])
            {
                month = 2;
            }
            else if (day.Number >= Month.DaysInMonths[0])
            {
                month = 1;
            }
            else
            {
                throw new Exception("Mês invalido");
            }

            return new Month(month);
        }

        /// <summary>
        /// Implicit cast of Day to Hour
        /// </summary>
        /// <param name="day">day class</param>
        /// <returns>Year class</returns>
        public static implicit operator Hour(Day day)
        {
            return new Hour(day.Number * Hours);
        }

        /// <summary>
        /// Implicit cast of Day to Minute
        /// </summary>
        /// <param name="hour">hour class</param>
        /// <returns>Year class</returns>
        public static implicit operator Minute(Day hour)
        {
            return (Hour)hour;
        }

        /// <summary>
        /// Sum hours to day
        /// </summary>
        /// <param name="day">day class</param>
        /// <param name="hour">hour class</param>
        /// <returns>Minute class</returns>
        public static Minute operator +(Day day, Hour hour)
        {
            return (Minute)day + (Minute)hour;
        }

        /// <summary>
        /// Parse string day to Day class
        /// </summary>
        /// <param name="str">string type</param>
        /// <returns>Day class</returns>
        public static Day Parse(string str)
        {
            var number = long.Parse(str);
            return new Day(number);
        }
    }
}