using System.Collections.Generic;
using System.Threading.Tasks;
using Harvest.Lib;
using WBSimms.Harvest.Models;

namespace ProduceForHarvest.Model
{
	public interface IDataService
	{
		Task<DataItem> GetData();
		Task<WhoAmI> WhoAmI();
		Task<Daily> Daily();
		Task<List<Projects>> Projects();
	}
}