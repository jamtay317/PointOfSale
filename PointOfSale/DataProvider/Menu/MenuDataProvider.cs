using System.Collections.Generic;
using System.Threading.Tasks;
using PointOfSale.MenuService;

namespace PointOfSale.DataProvider.Menu
{
    public class MenuDataProvider:IMenuDataProvider
    {
        private MenuServcieClient _menuClient;

        public MenuDataProvider()
        {
            _menuClient = new MenuServcieClient();
        }
        public Task<Category[]> GetCategoriesAsync()
        {
            return _menuClient.GetCategoriesAsync();
        }

        public Task<Category> GetCategory(int id)
        {
            return _menuClient.GetCategoryAsync(id);
        }

        public Task<Category> SaveCategory(Category category)
        {
            return _menuClient.SaveCategoryAsync(category);
        }
    }
}