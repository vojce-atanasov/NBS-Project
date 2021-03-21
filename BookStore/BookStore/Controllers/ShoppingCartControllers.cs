using BookStore.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class ShoppingCartControllers : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartControllers(IShoppingCartService shoppingCardService)
        {
            _shoppingCartService = shoppingCardService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
