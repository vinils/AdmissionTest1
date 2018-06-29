//-----------------------------------------------------------------------
// <copyright file="HourTest.cs" company="Test">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ViníciusLourençoSantos
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test of Hour class
    /// </summary>
    [TestClass]
    public class HourTest
    {
        /// <summary>
        /// Hour when parsed to minutes should be converted
        /// </summary>
        [TestMethod]
        public void Hour_WhenParsedToMinutes_ShouldBeConverted()
        {
            ////Arrange
            var hour = 1;
            var hourInMinutes = hour * Hour.Minutes;

            ////Act
            var objHour = Hour.Parse(hour.ToString());

            ////Assert
            if ((Minute)objHour != hourInMinutes.ToString())
            {
                throw new Exception("Erro");
            }
        }
    }
}