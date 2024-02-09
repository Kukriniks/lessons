using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Test
{
    [TestFixture]
    internal class ShopDiscounterTests
    {
        private IShopDiscounter shopDiscounter;

        [SetUp]
        public void Setup()
        { 
            var logger = new Mock<ILogger>();
           
            logger.Setup(l => l.Warn(It.IsAny<string>()));
            logger.Setup(l=>l.IsAvailable()).Returns(true);

            shopDiscounter = new ShopDiscounter(logger.Object);
        }

        [TestCase (10)]
        public void ShouldReturnItemWithCorrectPrice(int percent)
        {            
            var item = new ShopItem("test1", 100);

            var result = shopDiscounter.AddDiscountToItem(item, percent);
            Assert.That(result.Price, Is.EqualTo(90M));
        }

        [TestCase(101)]
        public void ShouldTrowExceptionWhenPercentValueIncorrect(int percent)
        {      
            var item = new ShopItem("test1", 100);

            var exception = Assert.Throws<Exception>(() =>
            {
                shopDiscounter.AddDiscountToItem(item, percent);
            });

            Assert.That(exception?.Message, Is.EqualTo("Wrong discount percent"));
        }


    }
}
