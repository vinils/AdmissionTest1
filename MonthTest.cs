//-----------------------------------------------------------------------
// <copyright file="MonthTest.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test of Month class
    /// </summary>
    [TestClass]
    public class MonthTest
    {
        /// <summary>
        /// Month when parsed to minutes should be converted
        /// </summary>
        [TestMethod]
        public void Month_WhenParsedToMinutes_ShouldBeConverted()
        {
            ////Arrange
            var month = 1;
            var monthInMinutes = Month.DaysInMonths[month - 1] * Day.Hours * Hour.Minutes;

            ////Act
            var objMonth = Month.Parse(month.ToString());

            ////Assert
            if ((Minute)objMonth != monthInMinutes.ToString())
            {
                throw new Exception("Erro");
            }
        }
    }
}