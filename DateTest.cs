//-----------------------------------------------------------------------
// <copyright file="DateTest.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test of Date class
    /// </summary>
    [TestClass]
    public class DateTest
    {
        /// <summary>
        /// String date when parsed should be the same
        /// </summary>
        [TestMethod]
        public void StringDate_WhenParsed_ShouldBeTheSame()
        {
            ////Arrange
            var date = "01/03/2010 23:00";

            ////Act
            var objDate = Date.Parse(date);

            ////Assert
            if (objDate != date)
            {
                throw new Exception("Erro");
            }
        }

        /// <summary>
        /// Date when added should work
        /// </summary>
        public void Date_WhenAdded_ShouldWork()
        {
            //////Arrange
            var date = Date.Parse("01/03/2010 23:00");
            var min = Minute.Parse("4000");

            ////Act
            var newDate = date + min;

            ////Assert
            if (newDate != "04/03/2010 17:40")
            {
                throw new Exception("Erro");
            }
        }

        /// <summary>
        /// Date when subtracted should work
        /// </summary>
        public void Date_WhenSubtracted_ShouldWork()
        {
            ////Arrange
            var date = Date.Parse("01/03/2010 23:00");
            var min = Minute.Parse("4000");

            ////Act
            var newDate = date - min;

            ////Assert
            if (newDate != "30/02/2010 04:20")
            {
                throw new Exception("Erro");
            }
        }
    }
}