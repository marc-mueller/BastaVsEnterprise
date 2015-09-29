using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.QualityTools.Testing.Fakes;

namespace CountdownLibrary.Tests.Unit
{
    [TestClass]
    public class CountdownTests
    {
        [TestMethod]
        public void CalculateCountdown_CorrectTimespan_WontWork()
        {
            // Arrange
            var target = new DateTime(2015, 09, 30, 19, 0, 0, DateTimeKind.Utc);

            // Act
            var countdown = Countdown.Calculate(target);

            // Assert
            Assert.AreEqual(new TimeSpan(2, 5, 0), countdown); // won't work
        }

        [TestMethod]
        public void CalculateCountdown_CorrectTimespan_Fakes()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                var target = new DateTime(2015, 09, 30, 19, 0, 0, DateTimeKind.Utc);

                // Act
                System.Fakes.ShimDateTime.UtcNowGet = () => new DateTime(2015, 09, 30, 16, 55, 0, DateTimeKind.Utc);
                var countdown = Countdown.Calculate(target);

                // Assert
                Assert.AreEqual(new TimeSpan(2, 5, 0), countdown);
            }
        }
    }
}
