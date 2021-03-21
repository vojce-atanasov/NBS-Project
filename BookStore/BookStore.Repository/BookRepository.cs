using BookStore.Data;
using BookStore.Entities;
using BookStore.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Repository
{    
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public void AddBook(Book book)
        {
            //" INSTERT INTO.... VALUES"           
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            Book book = GetBookById(bookId);
            _context.Books.Remove(book);
            _context.SaveChanges();

        }

        //public void DeleteBook(Book book)
        //{
            
        //    _context.Books.Remove(book);
        //    _context.SaveChanges();

        //}

        public void EditBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();

        }

        public void EditBook(int id)  
        {
            var book = GetBookById(id);
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {                                                                      /*Linq*/
            //var result = _context.Books.FromSqlRaw("SELECT * FROM Books").AsEnumerable();   ova celoto go krati so Linq kako vo dolniot red.
            var result = _context.Books.AsEnumerable();
            return result;
        }

        public Book GetBookById(int Id)
        {
            //var result = _context.Books.FromSqlRaw("SELECT * FROM Books WHERE Id = " + Id).FirstOrDefault();
            var result = _context.Books.FirstOrDefault(x => x.Id == Id);
            return result;
        }
    }
}
