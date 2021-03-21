using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Service.Interfaces
{
    public interface IAuthorService
    {
        void Add(Author author);
        void Edit(Author author);
        void Delete(int authorId);
        Author GetAuthorById(int id);
        IEnumerable<Author> GetAllAuthors();
    }
}
