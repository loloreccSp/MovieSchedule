using HomeWork12.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork12.Data.Configuration
{
	public class MovieConfiguration : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Name).HasColumnType("VARCHAR").IsRequired().HasMaxLength(50);
			builder.Property(x => x.Director).HasColumnType("VARCHAR").IsRequired().HasMaxLength(50);
			builder.Property(x => x.Style).HasColumnType("VARCHAR").IsRequired().HasMaxLength(50);
			builder.Property(x => x.Information).HasColumnType("VARCHAR").IsRequired().HasMaxLength(250);
			builder.Property(x => x.DateMovie).HasColumnType("DATE").IsRequired();
			builder.Property(x => x.TimeMovies).HasColumnType("TIME").IsRequired();
		}
	}
}
