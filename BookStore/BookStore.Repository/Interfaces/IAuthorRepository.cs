using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Interfaces
{
    public interface IAuthorRepository
    {
        void AddAuthor(Author author);
        void EditAuthor(Author author);
        void DeleteAuthor(int authorId);
        Author GetAuthorById(int id);
        IEnumerable<Author> GetAllAuthors();
    }
}
