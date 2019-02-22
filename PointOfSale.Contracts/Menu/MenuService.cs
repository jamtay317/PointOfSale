using System.Collections.Generic;
using System.Linq;
using PointOfSale.Data.Repository;
using PointOfSale.Models;

namespace PointOfSale.Contracts.Menu
{
    public class MenuService:IMenuServcie
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<MenuItem> _menuItemRepository;

        public MenuService(IRepository<Category> categoryRepository, IRepository<MenuItem> menuItemRepository)
        {
            _categoryRepository = categoryRepository;
            _menuItemRepository = menuItemRepository;
        }
        public ICollection<Category> GetCategories()
        {
            return _categoryRepository.Get().ToList();
        }

        public ICollection<MenuItem> GetCategoryMenuItems(int categoryId)
        {
            return _menuItemRepository.Get().Where(menuItem => menuItem.CategoryId == categoryId).ToList();
        }

        public MenuItem SaveMenuItem(MenuItem menuItem)
        {
            if (menuItem.Id == 0)
            {
                return _menuItemRepository.Post(menuItem);
            }

            return _menuItemRepository.Put(menuItem);
        }

        public Category SaveCategory(Category category)
        {
            if (category.Id == 0)
            {
                return _categoryRepository.Post(category);
            }
            return _categoryRepository.Put(category);
        }
    }
}