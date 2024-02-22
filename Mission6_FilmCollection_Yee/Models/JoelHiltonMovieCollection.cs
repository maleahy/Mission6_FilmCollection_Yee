using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mission6_FilmCollection_Yee.Models
{
    public class JoelHiltonMovieCollection
    {
        [Key]
        public int MovieId { get; set; } // Primary key

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be no less than 1888.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}