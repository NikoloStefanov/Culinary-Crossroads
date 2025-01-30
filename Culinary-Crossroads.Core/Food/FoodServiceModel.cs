using System.ComponentModel.DataAnnotations;

namespace Culinary_Crossroads.Core.Food
{
    public class FoodServiceModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Recipe { get; set; } = string.Empty;
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
