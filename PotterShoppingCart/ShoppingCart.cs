using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        private List<Book> _books;
        
        public ShoppingCart(List<Book> books)
        {
            this._books = books;
        }

        public object CalculateAmount()
        {
            return this._books.Sum( x => x.UnitPrice * x.Quantity );
        }
    }
}