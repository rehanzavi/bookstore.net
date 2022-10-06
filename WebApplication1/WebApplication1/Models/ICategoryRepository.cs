using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    internal interface ICategoryRepository
    {
        List<Category> GetAllCategory();
        Category GetCategoryByID(int id);
        Category AddCategory(Category category);
        void DeleteCategory(int catId);
        void UpdateCategory(Category category);
    }
}
