using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Culinary_Crossroads.Core.Enumeration;
using Culinary_Crossroads.Core.Food;

namespace Culinary_Crossroads.Core.Contacts
{
    public interface IFoodService
    {
        Task<IEnumerable<FoodCategoryServiceModel>> AllCategoriesAsync();

        Task<bool> CategoryExistAsync(int id);
        Task<int> CreateAsync(string title, string recipe, string imageURL, int categoryId, int agentId);
        Task<FoodQueryServiceModel> AllAsync(string category = null, string searchTerm = null
            , FoodSorting sorting = FoodSorting.Newest, int currentPage = 1, int foodPerPage = 1);
        Task<IEnumerable<string>> AllCategoriesNameAsync();
        Task<IEnumerable<FoodServiceModel>> AllRecipesByAgentIdAsync(int agentId);
        Task<bool> ExistsAsync(int id);
        Task<FoodDetailsServiceModel> FoodDetailsByIdAsync(int id);
        Task EditAsync(int foodId, string title, string recipe, string imageUrl, int categoryId);
        Task<bool> HasAgentWithIdAsync(int foodId, string currentUserId);
        Task<int> GetFoodCategoryIdAsync(int foodId);
        Task DeleteAsync(int id);
    }
}
