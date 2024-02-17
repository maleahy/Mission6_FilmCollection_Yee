using Microsoft.EntityFrameworkCore;

namespace Mission6_FilmCollection_Yee.Models
{
    public class add_movie_context : DbContext
    {
        public add_movie_context(DbContextOptions<add_movie_context>options):base(options) //constructor
        { 
        }
        public DbSet<add_movie> Movies { get; set; }
    }
}
