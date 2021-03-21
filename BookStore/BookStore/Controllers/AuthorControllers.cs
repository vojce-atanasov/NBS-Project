using BookStore.Entities;
using BookStore.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class AuthorControllers : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorControllers(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateAuthorAJAX(string name)
        {
            var author = new Author();
            return Json(author);
        }
    }
}
