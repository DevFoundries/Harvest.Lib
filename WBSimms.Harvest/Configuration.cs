using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBSimms.Harvest
{
	public class Configuration : IConfiguration
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public string CompanyName { get; set; }
	}
}
