using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        private List<Book> _books;
        private double _subTotal;

        private Dictionary<int, double> _ratioDiscount = new Dictionary<int, double>() {
            { 1, 1 },
            { 2, 0.95 },
            { 3, 0.9 },
            { 4, 0.8 },
            { 5, 0.75 }
        };

        public ShoppingCart(List<Book> books)
        {
            this._books = books;
        }

        public double CalculateAmount()
        {
            //計算書的最大數量
            var maxBooksCount = this._books.Max(x => x.Quantity);

            if (maxBooksCount == 0)
            {
                return 0;
            }

            for (var i = maxBooksCount; i > 0; i--)
            {
                double price = 0;
                int booksSetCount = 0;
                var unCheckBooks = this._books.Where(x => x.Quantity > 0);

                foreach (var book in unCheckBooks)
                {
                    price += book.UnitPrice;
                    booksSetCount++;
                    book.Quantity--;
                }

                double disCount = GetRatioDiscount(booksSetCount);
                this._subTotal += price * disCount;
                maxBooksCount--;
            }

            return this._subTotal;
        }

        private double GetRatioDiscount(int booksSetCount)
        {
            return this._ratioDiscount.Count() < booksSetCount ? 1 : this._ratioDiscount[booksSetCount];
        }
    }
}