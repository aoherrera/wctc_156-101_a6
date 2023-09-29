using System;
namespace ApplicationTemplate.Models
{
	public class Movie : Media
	{
		public string Genres { get; set; }

		public Movie() { }

		public override void Display()
		{
			//do something here.
		}
	}
}

