using System;
namespace XFFilter.Model
{
	public class Category
	{
		public Category ()
		{
	}
		public string Name { get; set; } = "Name";
		public string Value { get; set; } = "Value";
		public bool Selected { get; set; } = false;
	}
}
