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
            var list = _categoryRepository.Get().ToList();
            return list;
        }

        public Category GetCategory(int id)
        {
            return _categoryRepository.Get(id);
        }

        public ICollection<MenuItem> GetCategoryMenuItems(int categoryId)
        {
            return _menuItemRepository.Get().Where(menuItem => menuItem.CategoryId == categoryId).ToList();
        }

        public MenuItem GetMenuItem(int id)
        {
            return _menuItemRepository.Get(id);
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