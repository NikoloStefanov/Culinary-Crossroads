using Culinary_Crossroads.Core.Food;
using Culinary_Crossroads.Infrastructure.DataConstans;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Culinary_Crossroads.Food
{
    public class FoodFormModel
    {
        [Required]
        [StringLength(Constans.TitleMaxLength, MinimumLength = Constans.TitleMinLength)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(Constans.RecipeMaxLength, MinimumLength = Constans.RecipeMinLength)]
        public string Recipe { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public IEnumerable<FoodCategoryServiceModel> Categories { get; set; } = new List<FoodCategoryServiceModel>();
    }
}
