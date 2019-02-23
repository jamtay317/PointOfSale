using System.Collections.Generic;
using System.Threading.Tasks;
using PointOfSale.MenuService;

namespace PointOfSale.DataProvider.Menu
{
    public interface IMenuDataProvider
    {
        Task<Category[]> GetCategoriesAsync();

        Task<Category> GetCategory(int id);

        Task<Category> SaveCategory(Category category);
    }
}