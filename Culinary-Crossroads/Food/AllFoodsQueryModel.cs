using System.ComponentModel.DataAnnotations;
using Culinary_Crossroads.Core.Enumeration;
using Culinary_Crossroads.Core.Food;

namespace Culinary_Crossroads.Food
{
    public class AllFoodsQueryModel
    {
        public int FoodPerPage { get; } = 3;
        public string Category { get; init; } = string.Empty;
        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; } = string.Empty;
        public FoodSorting Sorting { get; init; }
        public int CurrentPage { get; init; } = 1;
        public int TotalFoodsCount { get; set; }
        public IEnumerable<string> Categories { get; set; } = null!;
        public IEnumerable<FoodServiceModel> Foods { get; set; } = new List<FoodServiceModel>();
    }
}
