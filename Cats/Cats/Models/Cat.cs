using System;
using Microsoft.WindowsAzure.MobileServices;

namespace Cats.Models
{
	[DataTable("Cats")]
	public class Cat
	{
		public String Id { get; set; }
		public String Name { get; set; }
		public String Description { get; set; }
		public String WebSite { get; set; }
		public String Image { get; set; }
		public int Price { get; set; }
		[Version]
		public string AzureVersion { get; set; }
	}
}
