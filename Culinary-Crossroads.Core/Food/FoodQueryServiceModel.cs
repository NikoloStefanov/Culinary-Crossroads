namespace Culinary_Crossroads.Core.Food
{
    public class FoodQueryServiceModel
    {  
        public int TotalFoodsCount { get; set; }
        public IEnumerable<FoodServiceModel> Foods { get; set; } = new List<FoodServiceModel>();
    }
}
