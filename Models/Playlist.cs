using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlaylistAPI.Models
{

    //class with properties
    public class Song
    {
        public int Id { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public int? Length { get; set; }

        //foreign key
        [Required]
        [ForeignKey("GenreId")]
        public int? GenreId { get; set; }
        public Genre? Genre { get; set; }
    }

    
    //class with properties
    public class Genre
    {
        public int? GenreId { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}

