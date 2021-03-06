using System.ComponentModel.DataAnnotations;

namespace MovieMakers.Models
{
    public class Hall
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Number of Rows")]
        [Required]
        [Range(1, 15)]
        public int NumberOfRows { get; set; }
    }
}