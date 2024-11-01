using System.Collections.Generic;
using System.Threading.Tasks;
using _72220591_UTS.Models;

public interface ICategoryService
{
    Task<IEnumerable<Category>> GetCategories();
    Task<Category> GetCategoryById(int id);
    Task AddCategory(Category category);
    Task UpdateCategory(Category category);
    Task DeleteCategory(int id);
}
