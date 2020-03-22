using System;
using System.Collections.Generic;
using System.Text;
using LuckyTickets.Extensions;
using Xunit;

namespace LuckyTicketsTests.Extensions
{
    public class IntExtensionsTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(10, 0, 1)]
        [InlineData(123, 3, 2, 1)]
        [InlineData(456, 6, 5, 4)]
        [InlineData(123456, 6, 5, 4, 3, 2, 1)]
        public void SplitToParts(int numbers, params int[] args)
        {
            // Arrange
            var expectedValue = new List<int>(args);

            // Act
            var actualValue = numbers.SplitToParts();

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}