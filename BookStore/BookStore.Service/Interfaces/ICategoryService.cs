using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Service.Interfaces
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Edit(Category category);
        void Delete(int categoryId);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategorys();
    }
}
