using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System;
using System.ComponentModel.DataAnnotations;
namespace Mission6_FilmCollection_Yee.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } // Primary key
        public string CategoryName { get; set; }
    }
}