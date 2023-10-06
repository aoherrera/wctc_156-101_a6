using System;
namespace Herrera_A6.Models
{
	public abstract class Media
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public Media() { }

		public abstract void Display(string filename);
	}
}

