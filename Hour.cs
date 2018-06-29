//-----------------------------------------------------------------------
// <copyright file="Hour.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;

    /// <summary>
    /// Hour class
    /// </summary>
    public class Hour : DateUnit
    {
        /// <summary>
        /// Minutes of one hour
        /// </summary>
        public const UInt16 Minutes = 60;

        /// <summary>
        /// Length of the string
        /// </summary>
        public const UInt16 Length = 2;

        /// <summary>
        /// Initializes a new instance of the <see cref="Hour"/> class
        /// </summary>
        /// <param name="hour">hour number</param>
        public Hour(long hour)
            : base(hour, Length)
        {
        }

        /// <summary>
        /// Implicit cast of Hour to Day
        /// </summary>
        /// <param name="hour">hour class</param>
        /// <returns>Day class</returns>
        public static implicit operator Day(Hour hour)
        {
            return new Day(hour.Number / Day.Hours);
        }

        /// <summary>
        /// Implicit cast of Hour to Minute
        /// </summary>
        /// <param name="hour">hour class</param>
        /// <returns>Minute class</returns>
        public static implicit operator Minute(Hour hour)
        {
            return new Minute(hour.Number * Minutes);
        }

        /// <summary>
        /// Implicit cast of Hour to Month
        /// </summary>
        /// <param name="hour">hour class</param>
        /// <returns>Month</returns>
        public static implicit operator Month(Hour hour)
        {
            return (Day)hour;
        }

        /// <summary>
        /// Implicit cast of Hour to Year
        /// </summary>
        /// <param name="hour">hour class</param>
        /// <returns>Year class</returns>
        public static implicit operator Year(Hour hour)
        {
            return (Day)hour;
        }

        /// <summary>
        /// Sum mintue to hour
        /// </summary>
        /// <param name="hour">hour class</param>
        /// <param name="mintue">minute class</param>
        /// <returns>Minute class</returns>
        public static Minute operator +(Hour hour, Minute mintue)
        {
            return (Minute)hour + mintue;
        }

        /// <summary>
        /// Parse string Hour to Hour class
        /// </summary>
        /// <param name="str">string type</param>
        /// <returns>Hour class</returns>
        public static Hour Parse(string str)
        {
            var number = long.Parse(str);
            return new Hour(number);
        }
    }
}