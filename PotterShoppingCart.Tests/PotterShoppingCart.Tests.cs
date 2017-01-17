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

        [TestMethod]
        public void 第一集買了一本_第二集也買了一本_價格應為190元()
        {
            //Scenario: 第一集買了一本，第二集也買了一本，價格應為100*2*0.95=190
            //	Given 第一集買了 1 本
            //	And 第二集買了 1 本
            //	And 第三集買了 0 本
            //	And 第四集買了 0 本
            //	And 第五集買了 0 本
            //	When 結帳
            //	Then 價格應為 190 元
            var books = new List<Book>
            {
                new Book() { Category = "Harry Potter", Episode = "First",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Second",  Quantity = 1, UnitPrice = 100}
            };
            var target = new ShoppingCart(books);

            //act
            var actual = target.CalculateAmount();

            //assert
            var expected = 190;
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void 一二三集各買了一本_價格應為270元()
        {
            //Scenario: 一二三集各買了一本，價格應為100*3*0.9=270
            //	Given 第一集買了 1 本
            //	And 第二集買了 1 本
            //	And 第三集買了 1 本
            //	And 第四集買了 0 本
            //	And 第五集買了 0 本
            //	When 結帳
            //	Then 價格應為 270 元
            var books = new List<Book>
            {
                new Book() { Category = "Harry Potter", Episode = "First",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Second",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Third",  Quantity = 1, UnitPrice = 100}
            };
            var target = new ShoppingCart(books);

            //act
            var actual = target.CalculateAmount();

            //assert
            var expected = 270;
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void 一二三四集各買了一本_價格應為320元()
        {
            //Scenario: 一二三四集各買了一本，價格應為100*4*0.8=320
            //	Given 第一集買了 1 本
            //	And 第二集買了 1 本
            //	And 第三集買了 1 本
            //	And 第四集買了 1 本
            //	And 第五集買了 0 本
            //	When 結帳
            //	Then 價格應為 320 元
            var books = new List<Book>
            {
                new Book() { Category = "Harry Potter", Episode = "First",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Second",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Third",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Fourth",  Quantity = 1, UnitPrice = 100}
            };
            var target = new ShoppingCart(books);

            //act
            var actual = target.CalculateAmount();

            //assert
            var expected = 320;
            actual.Should().Be(expected);
        }
    }
}
