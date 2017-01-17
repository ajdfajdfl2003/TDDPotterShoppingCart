using System;
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
            var bookCount = this._books.Count(x => x.Quantity > 0);

            if (bookCount == 0)
            {
                return 0;
            }

            var discount = this._ratioDiscount.Count() < bookCount ? 1 : this._ratioDiscount[bookCount];
            return this._books.Sum(x => x.UnitPrice * x.Quantity) * discount;
        }
    }
}