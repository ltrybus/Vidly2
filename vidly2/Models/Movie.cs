using System;
using System.ComponentModel.DataAnnotations;

namespace vidly2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Please enter the movie title.")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required (ErrorMessage="Please enter a valid release date")]
        [Display(Name = "Release Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime RelDate { get; set; }
        [Display(Name = "Recieve Date")]
        public DateTime? RecDate { get; set; }
        [Display(Name = "Number In Stock")]
        [Range(1,20, ErrorMessage ="Please enter a number between 1 and 20.")]
        public int QOH { get; set; }
        public Genres Genres { get; set; }
        [Display(Name = "Genre")]
        public int GenresId { get; set; }

     




    }


}