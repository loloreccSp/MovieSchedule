using System.ComponentModel.DataAnnotations;

namespace HomeWork12.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Director { get; set; }

        [Required]
        [MaxLength(50)]
        public string Style { get; set; }

        [Required]
        [MaxLength(250)]
        public string Information { get; set; }

        [Required]
        public DateOnly DateMovie { get; set; }

        [Required]
        public TimeOnly TimeMovies { get; set; }

    }
}
