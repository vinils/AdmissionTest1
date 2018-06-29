//-----------------------------------------------------------------------
// <copyright file="MinuteTest.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test of Minute class
    /// </summary>
    [TestClass]
    public class MinuteTest
    {
        /// <summary>
        /// String minute when parsed to minutes should be the same
        /// </summary>
        [TestMethod]
        public void StringMinute_WhenParsedToMinute_ShouldBeTheSame()
        {
            ////Arrange
            var minute = 1;

            ////Act
            var objMinute = Minute.Parse(minute.ToString());

            ////Assert
            if (objMinute != minute.ToString("00"))
            {
                throw new Exception("Erro");
            }
        }

        /// <summary>
        /// String minutes when parsed to hour should be converted
        /// </summary>
        [TestMethod]
        public void StringMinutes_WhenParsedToHour_ShouldBeConverted()
        {
            ////Arrange
            var hour = 1;
            var hourInMinutes = hour * Hour.Minutes;

            ////Act
            var minute = Minute.Parse(hourInMinutes.ToString());

            ////Assert
            if ((Hour)minute != hour.ToString("00"))
            {
                throw new Exception("Erro");
            }
        }

        /// <summary>
        /// String minutes when parsed to days should be converted
        /// </summary>
        [TestMethod]
        public void StringMinutes_WhenParsedToDays_ShouldBeConverted()
        {
            ////Arrange
            var day = 1;
            var dayInMinutes = day * Day.Hours * Hour.Minutes;

            ////Act
            var minute = Minute.Parse(dayInMinutes.ToString());

            ////Assert
            if ((Day)minute != day.ToString("00"))
            {
                throw new Exception("Erro");
            }
        }

        /// <summary>
        /// String minutes when parsed to months should be converted
        /// </summary>
        [TestMethod]
        public void StringMinutes_WhenParsedToMonth_ShouldBeConverted()
        {
            ////Arrange
            var month = 1;
            var monthInDays = Month.DaysInMonths[month - 1];
            var monthInMinutes = monthInDays * Day.Hours * Hour.Minutes;

            ////Act
            var minute = Minute.Parse(monthInMinutes.ToString());

            ////Assert
            if ((Month)minute != month.ToString("00"))
            {
                throw new Exception("Erro");
            }
        }

        /// <summary>
        /// String minutes when parsed to year should be converted
        /// </summary>
        [TestMethod]
        public void StringMinutes_WhenParsedToYear_ShouldBeConverted()
        {
            ////Arrange

            var year = 1;
            var yearInMinutes = year * Year.Days * Day.Hours * Hour.Minutes;

            ////Act
            var minute = Minute.Parse(yearInMinutes.ToString());

            ////Assert
            if ((Year)minute != year.ToString("0000"))
            {
                throw new Exception("Erro");
            }
        }
    }
}