using System;
namespace ApplicationTemplate.Models
{
	public abstract class Media
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public Media() { }

		public abstract void Display();
	}
}

