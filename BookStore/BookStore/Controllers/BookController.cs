
namespace BookStore.Controllers
{
    using BookStore.Entities;
    using BookStore.Service.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;

    public class BookController : Controller
    {
        
        private readonly IBookService _bookService;
        private readonly IConvertingService _convertingService;
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;
        private readonly IPublisherService _publisherService;

        public BookController(
            IBookService bookService,
            IConvertingService convertingService,
            IAuthorService authorService,
            ICategoryService categoryService,
            IPublisherService publisherService
            )
        {
            _bookService = bookService;
            _convertingService = convertingService;
            _authorService = authorService;
            _categoryService = categoryService;
            _publisherService = publisherService;

    }

        public IActionResult Index()
        {
            // code to be executed
            var books = _bookService.GetAllBooks();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            

            var categories = _categoryService.GetAllCategorys();

            var authors = _authorService.GetAllAuthors();

            var publishers = _publisherService.GetAllPublishers();

            var dropdowns = _bookService.FillDropdowns(categories, authors, publishers);


            //List<SelectListItem> Categories = new List<SelectListItem>()
            //{
            //    new SelectListItem() {Text="Romance", Value="1" , Selected = true },
            //    new SelectListItem() {Text="Drama", Value="2"},
            //    new SelectListItem() {Text="Adventure", Value="3"},
            //};

            //List<SelectListItem> Authors = new List<SelectListItem>()
            //{
            //    new SelectListItem() {Text="Agatha Christie", Value="1" , Selected = true  },
            //    new SelectListItem() {Text="Stephen King", Value="2"},
            //    new SelectListItem() {Text="William Shakspeare", Value="3"},
            //};

            //List<SelectListItem> Publisher = new List<SelectListItem>()
            //{
            //    new SelectListItem() {Text="William Morrow Paperbacks", Value="1" , Selected = true  },
            //    new SelectListItem() {Text="Scholastic", Value="2"},
            //    new SelectListItem() {Text="Penguin Random House", Value="3"},
            //};

            //var dropdowns = _bookService.FillDropdowns();
            //int stringTest = 1;
            //DateTime dataTime = DateTime.Now;

            //ViewBag.ConvertedValue = _convertingService.ConvertIntegerToString(stringTest);
            //ViewBag.ConvertedValueGenericType = _convertingService.ConvertAnyToString(dataTime);    na pocetokot gi imavme ovie toa e edne nachin samo so poveke pisuvanje 

            ViewBag.CategoryList = dropdowns.Item1;
            ViewBag.AuthorList = dropdowns.Item2; // za Author
            ViewBag.PublisherList = dropdowns.Item3; // za publisher  mora po redosled od book service

            //ViewBag.CategoryList = categories;
            //ViewBag.AuthorList = authors; // za Author
            //ViewBag.PublisherList = publishers;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Add(book);
            }

            return RedirectToAction(nameof(Index));
        }

        //GET: Books/Edit/2
        [HttpGet]       
        public IActionResult Edit(int id)
        {
            var categories = _categoryService.GetAllCategorys();
            var authors = _authorService.GetAllAuthors();
            var publishers = _publisherService.GetAllPublishers();
            var dropdowns = _bookService.FillDropdowns(categories, authors, publishers);

            ViewBag.CategoryList = dropdowns.Item1;
            ViewBag.AuthorList = dropdowns.Item2; // za Author
            ViewBag.PublisherList = dropdowns.Item3;                   

            //int stringTest = 1;
            //DateTime dataTime = DateTime.Now;

            //ViewBag.ConvertedValue = _convertingService.ConvertIntegerToString(stringTest);
            //ViewBag.ConvertedValueGenericType = _convertingService.ConvertAnyToString(dataTime);
            

            //var book = _bookService.GetBookById(id);
            return View();            

        }

        [HttpPost]
        public IActionResult Edit(int id, Book book)
        {
            //_bookService.Edit(book);         // moze i na ovaoj nacin da raboti 
            _bookService.Edit(id);
            return RedirectToAction (nameof(book));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var book = _bookService.GetBookById(id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = _bookService.GetBookById(id);
            return View(book);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // option 1
            var book = _bookService.GetBookById(id);
            _bookService.Delete(book.Id);
            // option 2
            //_bookService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
