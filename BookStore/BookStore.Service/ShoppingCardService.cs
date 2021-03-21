using BookStore.Repository.Interfaces;
using BookStore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Service
{
    public class ShoppingCardService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCardRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IBookRepository bookRepository;

        public ShoppingCardService(
            IShoppingCartRepository shoppingCardRepository,
            IBookRepository bookRepository)
        {
            _shoppingCardRepository = shoppingCardRepository;
            _bookRepository = bookRepository;

        }

        public IShoppingCartRepository ShoppingCardRepository => _shoppingCardRepository;
    }
}
