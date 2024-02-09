using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using Moq;

namespace ClassLibrary.Test
{
    [TestFixture]
    internal class ShopLoggerTests
    {
      
        [Test]
        public void ShopLoggerTest()
        {
            //Arrange
            var databaseMoq = new Mock<IDb>();
            databaseMoq.Setup( x => x.AddLogRecord(It.IsAny<string>()));
            ShopLogger shoplogger = new ShopLogger(databaseMoq.Object);
            string message = "test23";

            //Act
            shoplogger.Warn(message);

            //Assert
            databaseMoq.Verify(x => x.AddLogRecord($"WARN: {message}"));

            //Act
            shoplogger.Info(message);
            //Assert
            databaseMoq.Verify(x => x.AddLogRecord($"INFO: {message}"));

        }


    }
}
  