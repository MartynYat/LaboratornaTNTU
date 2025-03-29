using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "The Title field is required.")]
    [StringLength(100)]
    public string? Title { get; set; }

    [Display(Name = "Release Date")]
    [Required]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Required(ErrorMessage = "The Genre field is required.")]
    [StringLength(100)]
    public string? Genre { get; set; }

    [Required]
    [Range(0, 999.99)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [StringLength(5)]
    public string? Rating { get; set; }
}