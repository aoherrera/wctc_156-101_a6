using System;
namespace ApplicationTemplate.Models
{
	public class Show : Media
	{
        public int Season { get; set; }
        public int Episode { get; set; }
        public string Writers { get; set; }

        public Show() { }

        public override void Display()
        {
            //do something here.
        }
    }
}

