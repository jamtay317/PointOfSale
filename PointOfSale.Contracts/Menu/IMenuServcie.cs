using System.Collections.Generic;
using System.ServiceModel;
using PointOfSale.Models;

namespace PointOfSale.Contracts.Menu
{
    [ServiceContract]
    public interface IMenuServcie
    {
        [OperationContract]
        ICollection<Category> GetCategories();

        [OperationContract]
        ICollection<MenuItem> GetCategoryMenuItems(int categoryId);

        [OperationContract]
        MenuItem SaveMenuItem(MenuItem menuItem);

        [OperationContract]
        Category SaveCategory(Category category);
    }
}