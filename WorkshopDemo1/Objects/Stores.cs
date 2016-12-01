using System;
using System.Collections.Generic;

namespace WorkshopDemo1
{
	public class Location
	{
		public double lat { get; set; }
		public double lng { get; set; }
	}

	public class Store
	{
		public string place_id { get; set; }
		public string name { get; set; }
		public string formatted_address { get; set; }
		public string open_now { get; set; }
		public Location location { get; set; }
		public string photo_url { get; set; }
	}

	public class StoresObject
	{
		public List<Store> stores { get; set; }
		public bool error { get; set; }
	}
}
