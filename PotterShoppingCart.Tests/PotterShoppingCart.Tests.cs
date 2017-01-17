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

        [TestMethod]
        public void 一次買了整套_一二三四五集各買了一本_價格應為375元()
        {
            //Scenario: 一次買了整套，一二三四五集各買了一本，價格應為100*5*0.75=375
            //	Given 第一集買了 1 本
            //	And 第二集買了 1 本
            //	And 第三集買了 1 本
            //	And 第四集買了 1 本
            //	And 第五集買了 1 本
            //	When 結帳
            //	Then 價格應為 375 元
            var books = new List<Book>
            {
                new Book() { Category = "Harry Potter", Episode = "First",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Second",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Third",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Fourth",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Fifth",  Quantity = 1, UnitPrice = 100}
            };
            var target = new ShoppingCart(books);

            //act
            var actual = target.CalculateAmount();

            //assert
            var expected = 375;
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void 一二集各買了一本_第三集買了兩本_價格應為370元()
        {
            //Scenario: 一二集各買了一本，第三集買了兩本，價格應為100*3*0.9 + 100 = 370
            //	Given 第一集買了 1 本
            //	And 第二集買了 1 本
            //	And 第三集買了 2 本
            //	And 第四集買了 0 本
            //	And 第五集買了 0 本
            //	When 結帳
            //	Then 價格應為 370 元
            var books = new List<Book>
            {
                new Book() { Category = "Harry Potter", Episode = "First",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Second",  Quantity = 1, UnitPrice = 100},
                new Book() { Category = "Harry Potter", Episode = "Third",  Quantity = 2, UnitPrice = 100}
            };
            var target = new ShoppingCart(books);

            //act
            var actual = target.CalculateAmount();

            //assert
            var expected = 370;
            actual.Should().Be(expected);
        }
    }
}
