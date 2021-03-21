using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Interfaces
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        void EditBook(Book book);
        void EditBook(int id);
        void DeleteBook(int bookId);
        Book GetBookById(int Id);
        IEnumerable<Book> GetAllBooks();
       
    }
}
