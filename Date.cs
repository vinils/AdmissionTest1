//-----------------------------------------------------------------------
// <copyright file="Date.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;

    /// <summary>
    /// Date class
    /// </summary>
    public class Date
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Date" /> class
        /// </summary>
        /// <param name="minute">Total of minutes</param>
        protected Date(Minute minute)
        {
            this.Minute = minute;
        }

        /// <summary>
        /// Gets Date in minutes
        /// </summary>
        protected Minute Minute { get; private set; }

        /// <summary>
        /// Parse string date to Date class
        /// </summary>
        /// <param name="strDate">string date</param>
        /// <returns><see cref="Date"/> class</returns>
        public static Date Parse(string strDate)
        {
            var strDay = strDate.Substring(0, Day.Length);
            var strMonth = strDate.Substring(3, Month.Length);
            var strYear = strDate.Substring(6, Year.Length);
            var strHour = strDate.Substring(11, Hour.Length);
            var strMinute = strDate.Substring(14, Minute.Length);

            try
            {
                var day = Day.Parse(strDay);
                var month = Month.Parse(strMonth);
                var year = Year.Parse(strYear);
                var hour = Hour.Parse(strHour);
                var minute = Minute.Parse(strMinute);

                return new Date(year + month + day + hour + minute);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Implicit cast of Date to string
        /// </summary>
        /// <param name="date"><see cref="Date"/> class</param>
        /// <returns>string class</returns>
        public static implicit operator string(Date date)
        {
            return date.ToString();
        }

        /// <summary>
        /// Sum minute to date
        /// </summary>
        /// <param name="date">Date class</param>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <returns><see cref="Date"/> class</returns>
        public static Date operator +(Date date, Minute minute)
        {
            return new Date(date.Minute + minute);
        }

        /// <summary>
        /// Subtract minute to date
        /// </summary>
        /// <param name="date">Date class</param>
        /// <param name="minute"><see cref="Minute"/> class</param>
        /// <returns><see cref="Date"/> class</returns>        
        public static Date operator -(Date date, Minute minute)
        {
            return new Date(date.Minute - minute);
        }
        
        /// <summary>
        /// Cast to string as default
        /// </summary>
        /// <returns>string date</returns>
        public new string ToString()
        {
            var y = (Year)this.Minute;
            var m = (Month)(this.Minute - y);
            var d = (Day)(this.Minute - y - m);
            var h = (Hour)(this.Minute - y - m - d);
            var min = (Minute)(this.Minute - y - m - d - h);

            return d + "/" + m + "/" + y + " " + h + ":" + min;
        }
    }
}