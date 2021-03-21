using BookStore.Entities;
using BookStore.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Service.Interfaces
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public void Delete(int bookId)
        {
            _bookRepository.DeleteBook(bookId);
        }

        public void Edit(Book book)
        {
            _bookRepository.EditBook(book);
        }

        public void Edit(int id)
        {
            _bookRepository.EditBook(id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var result = _bookRepository.GetAllBooks();
            return result;
        }

        public Book GetBookById(int Id)
        {
            var result = _bookRepository.GetBookById(Id);
            return result;
        }

        #region Helper Functions

        public Tuple<List<SelectListItem>, List<SelectListItem>, List<SelectListItem>> FillDropdowns(
            IEnumerable<Category> categories,
            IEnumerable<Author> authors,
            IEnumerable<Publisher> publishers)
        {
            List<SelectListItem> Categories = new List<SelectListItem>
            {
                new SelectListItem {Value = "0", Text = "Select Category ..."}
            };

            List<SelectListItem> Authors = new List<SelectListItem>
            {
                new SelectListItem {Value = "0", Text = "Select Author ..."}
            };

            List<SelectListItem> Publishers = new List<SelectListItem>
            {
                new SelectListItem {Value = "0", Text = "Select Publisher ..."}
            };

            foreach (var category in categories)
            {                
                Categories.Add(new SelectListItem { Value = category.Id.ToString(), Text = category.Name });
            }

            foreach (var author in authors)
            {
                Authors.Add(new SelectListItem { Value = author.Id.ToString(), Text = author.Name });
            }

            foreach (var publisher in publishers)
            {
                Publishers.Add(new SelectListItem { Value = publisher.Id.ToString(), Text = publisher.Name });
            }

            return Tuple.Create(Categories, Authors, Publishers);

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

            //return Tuple.Create(Categories, Authors, Publisher);   

        }       

        #endregion
    }
}
