//-----------------------------------------------------------------------
// <copyright file="Year.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;

    /// <summary>
    /// Year class
    /// </summary>
    public class Year : DateUnit
    {
        /// <summary>
        /// Length of the string
        /// </summary>
        public const UInt16 Length = 4;

        /// <summary>
        /// Initializes a new instance of the <see cref="Year"/> class
        /// </summary>
        /// <param name="years">Year number</param>
        public Year(long years)
            : base(years, Length)
        {
        }

        /// <summary>
        /// Days in year
        /// </summary>
        public static readonly int Days = Month.Days[0] + Month.Days[1] + Month.Days[2] + Month.Days[3] + Month.Days[4] + Month.Days[5] + Month.Days[6] + Month.Days[7] + Month.Days[8] + Month.Days[9] + Month.Days[10] + Month.Days[11];

        /// <summary>
        /// Implicit cast of Year to Day
        /// </summary>
        /// <param name="year">Year class</param>
        /// <returns>Day class</returns>
        public static implicit operator Day(Year year)
        {
            return new Day(year.Number * Days);
        }

        /// <summary>
        /// Implicit cast of Year to Minute
        /// </summary>
        /// <param name="hour">Year class</param>
        /// <returns>Minute class</returns>
        public static implicit operator Minute(Year hour)
        {
            return (Day)hour;
        }

        /// <summary>
        /// Sum months to year
        /// </summary>
        /// <param name="year">year class</param>
        /// <param name="month">month class</param>
        /// <returns>Minute class</returns>
        public static Minute operator +(Year year, Month month)
        {
            return (Minute)year + (Minute)month;
        }

        /// <summary>
        /// Parse string Year to Year class
        /// </summary>
        /// <param name="str">string type</param>
        /// <returns>Year class</returns>
        public static Year Parse(string str)
        {
            var number = long.Parse(str);
            return new Year(number);
        }
    }
}
