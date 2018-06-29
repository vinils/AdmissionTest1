//-----------------------------------------------------------------------
// <copyright file="Month.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;

    /// <summary>
    /// Month class
    /// </summary>
    public class Month : DateUnit
    {
        /// <summary>
        /// Length of the string of the month
        /// </summary>
        public const UInt16 Length = 2;

        /// <summary>
        /// Create a instance Month class
        /// </summary>
        /// <param name="month">month class</param>
        public Month(long month)
            : base(month, Length)
        {
        }

        /// <summary>
        /// Implicit cast of Month to Day
        /// </summary>
        /// <param name="month">Month class</param>
        /// <returns>Day class</returns>
        public static implicit operator Day(Month month)
        {
            return new Day(DaysInMonths[month - 1]);
        }

        /// <summary>
        /// Implicit cast of Month to Minute
        /// </summary>
        /// <param name="hour">Month class</param>
        /// <returns>Minute class</returns>
        public static implicit operator Minute(Month hour)
        {
            return (Day)hour;
        }

        /// <summary>
        /// Implicit cast of Month to long
        /// </summary>
        /// <param name="hour">Month class</param>
        /// <returns>long number</returns>
        public static implicit operator long(Month hour)
        {
            return hour.Number;
        }

        /// <summary>
        /// Sum day to month
        /// </summary>
        /// <param name="month">month class</param>
        /// <param name="day">day class</param>
        /// <returns>Minute class</returns>
        public static Minute operator +(Month month, Day day)
        {
            return (Minute)month + (Minute)day;
        }

        /// <summary>
        /// Parse string Month to Month class
        /// </summary>
        /// <param name="str">string type</param>
        /// <returns>Month class</returns>
        public static Month Parse(string str)
        {
            var number = long.Parse(str);
            return new Month(number);
        }

        /// <summary>
        /// Days in each month
        /// </summary>
        public static readonly UInt16[] Days = new UInt16[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// <summary>
        /// Days in each month
        /// </summary>
        public static readonly int[] DaysInMonths = new int[] 
        { 
            Days[0], 
            Days[0] + Days[1], 
            Days[0] + Days[1] + Days[2],
            Days[0] + Days[1] + Days[2] + Days[3], 
            Days[0] + Days[1] + Days[2] + Days[3] + Days[4], 
            Days[0] + Days[1] + Days[2] + Days[3] + Days[4] + Days[5], 
            Days[0] + Days[1] + Days[2] + Days[3] + Days[4] + Days[5] + Days[6], 
            Days[0] + Days[1] + Days[2] + Days[3] + Days[4] + Days[5] + Days[6] + Days[7], 
            Days[0] + Days[1] + Days[2] + Days[3] + Days[4] + Days[5] + Days[6] + Days[7] + Days[8], 
            Days[0] + Days[1] + Days[2] + Days[3] + Days[4] + Days[5] + Days[6] + Days[7] + Days[8] + Days[9], 
            Days[0] + Days[1] + Days[2] + Days[3] + Days[4] + Days[5] + Days[6] + Days[7] + Days[8] + Days[9] + Days[10], 
            Days[0] + Days[1] + Days[2] + Days[3] + Days[4] + Days[5] + Days[6] + Days[7] + Days[8] + Days[9] + Days[10] + Days[11]
        };
    }
}