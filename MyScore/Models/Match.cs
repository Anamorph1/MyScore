using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyScore.Models
{
	public class Match
	{
		public string Home { get; set; }
		public string Away { get; set; }
		public string Place { get; set; }
		public DateTime dateTime = DateTime.Now;
		public int[] score = new int[2] { 0, 0 };
		public string Referee { get; set; }
		//List<Event> events;
		public long UserId { get; set; }
		public string League { get; set; }
    }
}