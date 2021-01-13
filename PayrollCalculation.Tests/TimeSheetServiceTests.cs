using System;
using NUnit.Framework;
using PayrollCalculation.Api.Models;
using PayrollCalculation.Api.Services;

namespace PayrollCalculation.Tests
{
    public class TimeSheetServiceTests
    {
        [Test]
        public void TrackTime_ShouldReturnTrue()
        {
            //arrange
            var service = new TimeSheetService();

            //act
            var result = service.TrackTime();

            //assert
            Assert.IsTrue(result);
        }
        
        [Test]
        public void TrackTime_ShouldReturnFalse()
        {
            //arrange
            var timeLog = new TimeLog()
            {
                Date = new DateTime(),
                WorkingHours = 1,
                LastName = "",
            };

            var service = new TimeSheetService();

            //act
            var result = service.TrackTime(timeLog);

            //assert
            Assert.IsTrue(result);
        }

    }
}