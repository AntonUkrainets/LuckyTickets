using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LuckyTickets.Core;
using Xunit;

namespace LuckyTicketsTests.Core
{
    public class InputDataParserTests
    {
        [Fact]
        public void GetTicketsTask_Positive()
        {
            // Arrange
            var args = new string[]
            {
                "File.txt"
            };

            var expectedTicketsTask = new TicketsTask
            {
                Algorithm = "Piter"
            };

            // Act
            var actualTicketsTask = InputDataParser.GetTicketsTask(args);

            // Assert
            Assert.Equal(expectedTicketsTask.Algorithm, actualTicketsTask.Algorithm);
        }

        [Fact]
        public void GetTicketsTask_Negative()
        {
            // Arrange
            var args = new string[]
            {
               "Nothing"
            };

            // Assert
            Assert.Throws<FileNotFoundException>(() => InputDataParser.GetTicketsTask(args));
        }
    }
}