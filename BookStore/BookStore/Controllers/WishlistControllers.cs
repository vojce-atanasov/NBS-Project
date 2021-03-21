using BookStore.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class WishlistControllers : Controller
    {
        private readonly IWishlistService _wishlistService;

        public WishlistControllers(IWishlistService wishlistService)
        {
            _wishlistService = wishlistService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
