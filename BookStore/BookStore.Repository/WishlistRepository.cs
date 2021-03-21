using BookStore.Data;
using BookStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository
{
    public class WishlistRepository : IWishlistRepository
    {
        private readonly DataContext _context;

        public WishlistRepository(DataContext context)
        {
            _context = context;
        }
    }
}
