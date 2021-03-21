using BookStore.Repository.Interfaces;
using BookStore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Service
{
    public class WishlistService : IWishlistService
    {
        private readonly IWishlistRepository _wishlistRepository;

        public WishlistService(IWishlistRepository wishlistRepository)
        {
            _wishlistRepository = wishlistRepository;
        }
    }
}
