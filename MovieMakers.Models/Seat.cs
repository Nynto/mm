using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieMakers.Models
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RowId { get; set; }
        [ForeignKey("RowId")]
        public Row Row { get; set; }

        [Required]
        public int Number { get; set; }
    }
}