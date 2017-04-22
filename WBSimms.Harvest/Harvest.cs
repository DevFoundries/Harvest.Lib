using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Harvest.Lib;
using Newtonsoft.Json;
using WBSimms.Harvest.Models;
using HttpClient = System.Net.Http.HttpClient;

namespace WBSimms.Harvest
{
	public interface IHarvest
	{
		WhoAmI WhoAmI();
		Daily Daily();
		Project Project(int projectId);
		List<Projects> Projects();
		Daily Daily(int dayOfYear, int year);
		Daily DailySlim();

	}

	public class Harvest : IHarvest
	{
		private HttpClient httpClient;

		public Harvest(IConfiguration config)
		{
			this.httpClient = new HttpClient();
			string svcCredentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(config.UserName+ ":" + config.Password));
			httpClient = new HttpClient();

			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", svcCredentials);
			httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
			httpClient.BaseAddress = new Uri("https://"+config.CompanyName+".harvestapp.com");
		}

		public WhoAmI WhoAmI()
		{
			var result = httpClient.GetStringAsync("/account/who_am_i").Result;
			var company = JsonConvert.DeserializeObject<WhoAmI>(result);
			return company;
		}

		public Daily Daily()
		{
			var result = httpClient.GetStringAsync("/daily").Result;
			var retval = JsonConvert.DeserializeObject<Daily>(result);
			return retval;
		}

		public Daily DailySlim()
		{
			var result = httpClient.GetStringAsync("/daily?slim=1").Result;
			var retval = JsonConvert.DeserializeObject<Daily>(result);
			return retval;
		}

		public Daily Daily(int dayOfYear, int year)
		{
			if (dayOfYear < 1 || dayOfYear > 366) throw new ArgumentException("dayofYear");
			var result = httpClient.GetStringAsync("/daily/"+dayOfYear+"/"+year).Result;
			var retval = JsonConvert.DeserializeObject<Daily>(result);
			return retval;
		}



		public List<Projects> Projects()
		{
			var result = httpClient.GetStringAsync("/projects").Result;
			var retval = JsonConvert.DeserializeObject<List<Projects>>(result);
			return retval;
		}

		public Project Project(int projectId)
		{
			var result = httpClient.GetStringAsync("/projects/"+projectId).Result;
			var retval = JsonConvert.DeserializeObject<Projects>(result);
			return retval.Project;
		}

		public Daily DailyAdd(Daily daily)
		{
			var result = httpClient.PostAsync("daily/add", new System.Net.Http.StringContent(JsonConvert.SerializeObject(daily))).Result;
			var retval = JsonConvert.DeserializeObject<Daily>(result.Content.ReadAsStringAsync().Result);
			return retval;
		}

	}
}
