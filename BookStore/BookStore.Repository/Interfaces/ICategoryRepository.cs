using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(int categoryId);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategorys();
    }
}
