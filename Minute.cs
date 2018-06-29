//-----------------------------------------------------------------------
// <copyright file="Minute.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;

    /// <summary>
    /// Minute class
    /// </summary>
    public class Minute : DateUnit
    {
        /// <summary>
        /// Length of the string
        /// </summary>
        public const UInt16 Length = 2;

        /// <summary>
        /// Initializes a new instance of the <see cref="Minute"/> class
        /// </summary>
        /// <param name="minutes">Minute number</param>
        public Minute(long minutes)
            : base(minutes, Length)
        {
        }

        /// <summary>
        /// Implicit cast of Minute to Hour
        /// </summary>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <returns>Hour</returns>
        public static implicit operator Hour(Minute minute)
        {
            return new Hour(minute.Number / Hour.Minutes);
        }

        /// <summary>
        /// Implicit cast of Minute to Day
        /// </summary>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <returns>Day class</returns>
        public static implicit operator Day(Minute minute)
        {
            return (Hour)minute;
        }

        /// <summary>
        /// Implicit cast of Minute to Month
        /// </summary>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <returns>Month</returns>
        public static implicit operator Month(Minute minute)
        {
            return (Hour)minute;
        }

        /// <summary>
        /// Implicit cast of Minute to Year
        /// </summary>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <returns>Year class</returns>
        public static implicit operator Year(Minute minute)
        {
            return (Day)minute;
        }

        /// <summary>
        /// Sum minutes
        /// </summary>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <param name="minute2">Minute2 class</param>
        /// <returns>Minute class</returns>
        public static Minute operator +(Minute minute, Minute minute2)
        {
            return new Minute(minute.Number + minute2.Number);
        }

        /// <summary>
        /// Subtract minutes
        /// </summary>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <param name="minute2">Minute2 class</param>
        /// <returns>Minute class</returns>        
        public static Minute operator -(Minute minute, Minute minute2)
        {
            return new Minute(minute.Number - minute2.Number);
        }

        /// <summary>
        /// Sum hour to minutes
        /// </summary>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <param name="hour">hour class</param>
        /// <returns>Minute class</returns>
        public static Minute operator +(Minute minute, Hour hour)
        {
            return minute + (Minute)hour;
        }

        /// <summary>
        /// Sum day to minutes
        /// </summary>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <param name="day">day class</param>
        /// <returns>Minute class</returns>
        public static Minute operator +(Minute minute, Day day)
        {
            return minute + (Minute)day;
        }

        /// <summary>
        /// Sum month to minutes
        /// </summary>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <param name="month">month class</param>
        /// <returns>Minute class</returns>
        public static Minute operator +(Minute minute, Month month)
        {
            return minute + month;
        }

        /// <summary>
        /// Parse string to Minute
        /// </summary>
        /// <param name="str">minutes in string</param>
        /// <returns>Minute class</returns>
        public static Minute Parse(string str)
        {
            var number = long.Parse(str);
            return new Minute(number);
        }
    }
}