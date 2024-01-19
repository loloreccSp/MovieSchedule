using System.ComponentModel.DataAnnotations;

namespace HomeWork12.Models
{
    public class MovieTimeList
    {
        public int Id { get; set; }

        [Required]
        public int MovieId { get; set; }

        public Movie MovieObj { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeOnly Time { get; set; }
    }
}
