using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System;
using System.ComponentModel.DataAnnotations;
namespace Mission6_FilmCollection_Yee.Models
{
    public class add_movie
    {
        public int ID { get; set; } // Primary key

        [Required]
        public string Category { get; set; }

        [Required]
        public string MovieTitle { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        [RegularExpression(@"^\d{4}(-\d{4})?$", ErrorMessage = "Release year must be a 4-digit number or a range like 2012-2013.")]
        public string ReleaseYear { get; set; }

        [Required]
        public string Rating { get; set; }

        // Not required fields
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }
    }
}