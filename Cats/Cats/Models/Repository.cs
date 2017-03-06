using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmHelpers;

namespace Cats.Models
{
	public class Repository
	{
		//To use use a web api
		//public async Task<ObservableRangeCollection<Cat>> GetCats()
		//{
		//	ObservableRangeCollection<Cat> Cats;
		//	var URLWebAPI = "http://demos.ticapacitacion.com/cats";
		//	using (var Client = new System.Net.Http.HttpClient())
		//	{
		//		var JSON = await Client.GetStringAsync(URLWebAPI);
		//		Cats = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableRangeCollection<Cat>>(JSON);
		//	}
		//	return Cats;
		//}

		public async Task<IEnumerable<Cat>> GetCats()
		{
			var service = new Services.AzureService<Cat>();
			var items = await service.GetTable();
			return items;
		}
	}
}
