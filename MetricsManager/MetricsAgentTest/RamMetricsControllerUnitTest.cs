using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTests
{
    public class RamMetricsControllerUnitTest
    {
        private RamMetricsController controller;

        public RamMetricsControllerUnitTest()
        {
            controller = new RamMetricsController();
        }

        [Fact]
        public void GetMetrics_ReturnsOk()
        {
            //Arrange
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = controller.GetMetrics(fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }


    }
}
