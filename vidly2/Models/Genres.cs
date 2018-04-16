using System.ComponentModel.DataAnnotations;

namespace vidly2.Models
{
    public class Genres
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string GenreDescription { get; set; }
       
    }
}