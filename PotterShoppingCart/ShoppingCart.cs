using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        private List<Book> _books;

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
            var maxCount = this._books.Max(x => x.Quantity);
            double subTotal = 0;
            if (maxCount == 0)
            {
                return 0;
            }

            for (var i = maxCount; i > 0; i--)
            {
                int booksSetCount = 0;
                double _price = 0;
                foreach (var _book in this._books.Where(x => x.Quantity > 0))
                {
                    _price += _book.UnitPrice;
                    booksSetCount++;
                    _book.Quantity--;
                }

                var discount = this._ratioDiscount.Count() < booksSetCount ? 1 : this._ratioDiscount[booksSetCount];
                subTotal += _price * discount;
                maxCount--;
            }

            return subTotal;
        }
    }
}