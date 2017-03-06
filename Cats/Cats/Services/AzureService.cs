using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Cats.Services
{
	public class AzureService<T>
	{
		IMobileServiceClient client;
		IMobileServiceTable<T> table;

		public AzureService()
		{
			string myAppServiceURL = "http://catscmf.azurewebsites.net";
			client = new MobileServiceClient(myAppServiceURL);
			table = client.GetTable<T>();
		}

		public Task<IEnumerable<T>> GetTable()
		{
			return table.ToEnumerableAsync();
		}
	}
}
