using System;
using System.ComponentModel.DataAnnotations;

namespace Rently.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 30)]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }

    }
}