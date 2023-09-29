﻿using System;
namespace ApplicationTemplate.Models
{
	public class Video : Media
	{
        public string Format { get; set; }
        public int Length { get; set; }
        public int Regions { get; set; }
		public Video() { }

        public override void Display()
        {
            //and now for something completely different.
        }
    }
}
