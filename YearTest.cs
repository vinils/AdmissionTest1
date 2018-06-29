//-----------------------------------------------------------------------
// <copyright file="YearTest.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test of year class
    /// </summary>
    [TestClass]
    public class YearTest
    {
        /// <summary>
        /// Year when parse to minutes should be converted
        /// </summary>
        [TestMethod]
        public void Year_WhenParsedToMinutes_ShouldBeConverted()
        {
            ////Arrange
            var year = 1;
            var yearInMinutes = year * Year.Days * Day.Hours * Hour.Minutes;

            ////Act
            var objYear = Year.Parse(year.ToString());

            ////Assert
            if ((Minute)objYear != yearInMinutes.ToString())
            {
                throw new Exception("Erro");
            }
        }
    }
}