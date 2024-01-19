using HomeWork12.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork12.Data
{
	public class DbInitializer
	{
		private ModelBuilder _modelBuilder;

		public DbInitializer(ModelBuilder modelBuilder)
		{
			_modelBuilder = modelBuilder;
		}
	}
}
