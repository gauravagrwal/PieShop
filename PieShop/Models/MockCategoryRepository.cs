using System.Collections.Generic;

namespace PieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{ CategoryId=1,CategoryName="Fruit Pies", Description="All Fruit Pies"},
                new Category{ CategoryId=2,CategoryName="Cheese Cakes", Description="All Cheese Cakes"}
            };
    }
}
