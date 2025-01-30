using Culinary_Crossroads.Core.Agent;

namespace Culinary_Crossroads.Core.Food
{
    public class FoodDetailsServiceModel : FoodServiceModel
    {
        public string Category { get; set; } = string.Empty;
        public AgentServiceModel Agent { get; set; } = null!;
    }
}
