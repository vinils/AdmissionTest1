//-----------------------------------------------------------------------
// <copyright file="DayTest.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test of Day class
    /// </summary>
    [TestClass]
    public class DayTest
    {
        /// <summary>
        /// Day when parsed should be converted
        /// </summary>
        [TestMethod]
        public void Day_WhenParsedToMinutes_ShouldBeConverted()
        {
            ////Arrange
            var day = 1;
            var dayInMinutes = day * Day.Hours * Hour.Minutes;

            ////Act
            var objDay = Day.Parse(day.ToString());

            ////Assert
            if ((Minute)objDay != dayInMinutes.ToString())
            {
                throw new Exception("Erro");
            }
        }
    }
}