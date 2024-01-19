using HomeWork12.Data;
using HomeWork12.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork12.Controllers
{
	public class MovieController : Controller
	{
		private ApplicationMovieDbContext _context { get; set; }

		public MovieController(ApplicationMovieDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			IEnumerable<Movie> movie = _context.Movies;

			return View(movie);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
			if (ModelState.IsValid)
			{
				_context.Movies.Add(movie);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
            return View(movie);
        }

		public IActionResult Edit(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}

            var movie = _context.Movies.FirstOrDefault(x => x.Id == id);

			if (movie == null) 
			{
                return NotFound();
            }

			return View(movie);
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Movie movie)
		{
			if (ModelState.IsValid) 
			{
				_context.Movies.Update(movie);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(movie);
		}

		public IActionResult Delete(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}

			var movie = _context.Movies.FirstOrDefault(x => x.Id == id);

			if (movie == null) 
			{
				return NotFound();
			}

			return View(movie);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteMovie(int id)
		{
			if (ModelState.IsValid)
			{
				var check = _context.Movies.SingleOrDefault(x => x.Id == id);

				if (check != null) 
				{
					_context.Movies.Remove(check);
					_context.SaveChanges();
					return RedirectToAction("Index");
				}
			}
			return View();
		}
    }
}
