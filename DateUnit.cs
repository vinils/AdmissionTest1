//-----------------------------------------------------------------------
// <copyright file="DateUnit.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;

    /// <summary>
    /// DateUnite class
    /// </summary>
    public abstract class DateUnit
    {
        /// <summary>
        /// number of the unit
        /// </summary>
        protected readonly long Number;

        /// <summary>
        /// Length of the string
        /// </summary>
        protected readonly UInt16 StringLength;

        /// <summary>
        /// Initializes a new instance of the <see cref="DateUnit"/> class
        /// </summary>
        /// <param name="number">number of units</param>
        /// <param name="length">length of the string</param>
        public DateUnit(long number, UInt16 length)
        {
            this.Number = number;
            this.StringLength = length;
        }

        /// <summary>
        /// Implicit cast of DateUnit to string
        /// </summary>
        /// <param name="date"><see cref="DateUnit"/> class</param>
        /// <returns>string unit</returns>
        public static implicit operator string(DateUnit date)
        {
            return date.ToString();
        }

        /// <summary>
        /// Cast to string with 2 decimal
        /// </summary>
        /// <returns>string unit</returns>
        public new string ToString()
        {
            var ret = this.Number;
            ////var ret =  (number == 0) ? 1 : number;
            return ret.ToString("D" + this.StringLength);
        }
    }
}