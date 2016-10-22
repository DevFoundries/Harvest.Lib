using System.Collections.Generic;
using System.Threading.Tasks;
using Harvest.Lib;
using WBSimms.Harvest;
using WBSimms.Harvest.Models;

namespace ProduceForHarvest.Model
{
	public class DataService : IDataService
	{
		private Configuration config = new Configuration()
		{
			CompanyName = "wbsimms",
			Password = "Comp533!",
			UserName = "barrett@wbsimms.com"
		};

		public Task<DataItem> GetData()
		{
			// Use this to connect to the actual data service

			// Simulate by returning a DataItem
			var item = new DataItem("Welcome to MVVM Light");
			return Task.FromResult(item);
		}

		public Task<WhoAmI> WhoAmI()
		{
			WBSimms.Harvest.Harvest h = new WBSimms.Harvest.Harvest(config);
			return Task.FromResult(h.WhoAmI());

		}

		public Task<Daily> Daily()
		{
			WBSimms.Harvest.Harvest h = new WBSimms.Harvest.Harvest(config);
			return Task.FromResult(h.Daily());

		}

		public Task<List<Projects>> Projects()
		{
			WBSimms.Harvest.Harvest h = new WBSimms.Harvest.Harvest(config);
			return Task.FromResult(h.Projects());
		}
	}

}