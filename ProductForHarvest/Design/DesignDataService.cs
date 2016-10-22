using System.Collections.Generic;
using System.Threading.Tasks;
using Harvest.Lib;
using ProduceForHarvest.Model;
using WBSimms.Harvest.Models;

namespace ProduceForHarvest.Design
{
	public class DesignDataService : IDataService
	{
		public Task<DataItem> GetData()
		{
			// Use this to create design time data

			var item = new DataItem("Welcome to MVVM Light [design]");
			return Task.FromResult(item);
		}

		public Task<WhoAmI> WhoAmI()
		{
			return Task.FromResult(new WhoAmI());
		}

		public Task<Daily> Daily()
		{
			return Task.FromResult(new Daily());
		}

		public Task<List<Projects>> Projects()
		{
			return Task.FromResult(new List<Projects>());
		}
	}
}