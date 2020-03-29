using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Identity;

namespace MovieMakers.Models
{
    public class ApplicationUser : IdentityUser
    {
    [Required]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")] public Company Company { get; set; }
        
        [NotMapped] public string Role { get; set; }
        
    }
}