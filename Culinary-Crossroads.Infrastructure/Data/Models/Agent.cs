﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Culinary_Crossroads.Infrastructure.DataConstans;
using Microsoft.AspNetCore.Identity;

namespace Culinary_Crossroads.Infrastructure.Data.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constans.PhoneNumeberMaxLength)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}
