using BookStore.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace BookStore.Service.Interfaces
{
    public interface IBookService
    {
        void Add(Book book);
        void Edit(Book book);
        void Edit(int id);
        void Delete(int bookId);
        Book GetBookById(int Id);
        IEnumerable<Book> GetAllBooks();

        Tuple<List<SelectListItem>, List<SelectListItem>, List<SelectListItem>> FillDropdowns(
            IEnumerable<Category> categories,
            IEnumerable<Author> authors, 
            IEnumerable<Publisher> publishers);
        
    }
}
