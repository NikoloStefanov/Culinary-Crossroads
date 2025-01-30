using Culinary_Crossroads.Infrastructure.DataConstans;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Culinary_Crossroads.Agent
{
    public class BecomeAgentFormModel
    {
        [Required]
        [StringLength(Constans.PhoneNumeberMaxLength)]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
