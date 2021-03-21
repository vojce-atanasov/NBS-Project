using BookStore.Data;
using BookStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly DataContext _context;

        public ShoppingCartRepository(DataContext context)
        {
            _context = context;
        }
    }
}
