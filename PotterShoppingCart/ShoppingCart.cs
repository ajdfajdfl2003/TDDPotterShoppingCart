using System;
using System.Collections.Generic;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        private List<Book> books;
        
        public ShoppingCart(List<Book> books)
        {
            this.books = books;
        }

        public object CalculateAmount()
        {
            throw new NotImplementedException();
        }
    }
}