using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyScore.Models
{
	public class Match
	{
		public string home;
		public string away;
		public string place;
		public DateTime dateTime = DateTime.Now;
		public int[] score = new int[2] { 0, 0 };
		public string referee;
		//List<Event> events;
		public long userId;
		public string league;
	}
}