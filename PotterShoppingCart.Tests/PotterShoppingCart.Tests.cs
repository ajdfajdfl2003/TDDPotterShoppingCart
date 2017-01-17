using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    /// <summary>
    /// PotterShoppingCart 的摘要描述
    /// </summary>
    [TestClass]
    public class PotterShoppingCartTests
    {
        [TestMethod]
        public void 第一集買了一本_其他都沒買_價格應為100元()
        {
            //Scenario: 第一集買了一本，其他都沒買，價格應為100 * 1 = 100元
            //        Given 第一集買了 1 本
            //        And 第二集買了 0 本
            //        And 第三集買了 0 本
            //        And 第四集買了 0 本
            //        And 第五集買了 0 本
            //        When 結帳
            //        Then 價格應為 100 元
            var books = new List<Book>
            {
                new Book() { Category = "Harry Potter", Episode = "First",  Quantity = 1, UnitPrice = 100}
            };
            var target = new ShoppingCart(books);

            //act
            var actual = target.CalculateAmount();

            //assert
            var expected = 100;
            actual.Should().Be(expected);
        }
    }
}
