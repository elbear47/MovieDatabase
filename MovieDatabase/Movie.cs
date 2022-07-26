using System;
namespace MovieDatabase
{
	public class Movie
	{
		private string title;
		private string category;

		public Movie(string title, string category)
		{
			Title = title;
			Category = category;
		}
		public string Title { get; set; }
		public string Category { get; set; }

		public void getTitleBasedOnCategory(string cat)
        {
			Category = cat;

            Console.WriteLine(cat);
        }
		
	}
	
}

