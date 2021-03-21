using BookStore.Entities;
using BookStore.Repository.Interfaces;
using BookStore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Service
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(Author author)
        {
            _authorRepository.AddAuthor(author);
        }

        public void Delete(int authorId)
        {
            _authorRepository.DeleteAuthor(authorId);
        }

        public void Edit(Author author)
        {
            _authorRepository.EditAuthor(author);
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            var result = _authorRepository.GetAllAuthors();
            return result;
        }

        public Author GetAuthorById(int id)
        {
            var result = _authorRepository.GetAuthorById(id);
            return result;
        }
    }
}
