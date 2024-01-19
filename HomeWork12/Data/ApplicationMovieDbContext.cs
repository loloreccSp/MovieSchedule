using HomeWork12.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork12.Data
{
	public class ApplicationMovieDbContext : DbContext
	{
		public ApplicationMovieDbContext(DbContextOptions<ApplicationMovieDbContext> options) : base(options) { }


		public DbSet<Movie> Movies { get; set; }
		public DbSet<MovieTimeList> Times { get; set; }
	}
}
