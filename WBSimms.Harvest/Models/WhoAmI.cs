using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using Newtonsoft.Json;

namespace Harvest.Lib
{
	public class WhoAmI
	{
		public Company Company { get; set; }
		public User User { get; set; }
	}

	public class User
	{
		[JsonProperty("timezone")]
		public string Timezone { get; set; }
		[JsonProperty("timezone_identifier")]
		public string TimezoneIdentifier { get; set; }
		[JsonProperty("timezone_utc_offset")]
		public string TimezoneUTCOffset { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("email")]
		public string Email { get; set; }
		[JsonProperty("admin")]
		public string Admin { get; set; }
		[JsonProperty("first_name")]
		public string FirstName { get; set; }
		[JsonProperty("last_name")]
		public string LastName { get; set; }
		[JsonProperty("avatar_url")]
		public string AvatarUrl { get; set; }
		[JsonProperty("project_manager")]
		public ProjectManager ProjectManager { get; set; }
		[JsonProperty("timestamp_timers")]
		public bool TimestampTimers { get; set; }
	}

	public class ProjectManager
	{
		[JsonProperty("is_project_manager")]
		public bool IsProjectManager { get; set; }
		[JsonProperty("can_see_rates")]
		public bool CanSeeRates { get; set; }
		[JsonProperty("can_create_projects")]
		public bool CanCreateProjects { get; set; }
		[JsonProperty("can_create_invoices")]
		public bool CanCreateInvoices { get; set; }
	}

	public class Company
	{
		[JsonProperty("base_uri")]
		public Uri BaseUri { get; set; }
		[JsonProperty("full_domain")]
		public string FullDomain { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("active")]
		public bool Active { get; set; }
		[JsonProperty("week_start_day")]
		public string WeekStartDay { get; set; }
		[JsonProperty("time_format")]
		public string TimeFormat { get; set; }
		[JsonProperty("clock")]
		public string Clock { get; set; }
		[JsonProperty("decimal_symbol")]
		public string DecimalSymbol { get; set; }
		[JsonProperty("color_scheme")]
		public string ColorScheme { get; set; }
		[JsonProperty("modules")]
		public Modules Modules { get; set; }
		[JsonProperty("thousands_separator")]
		public string ThousandsSeparator { get; set; }
		[JsonProperty("plan_type")]
		public string PlanType { get; set; }
	}

	public class Modules
	{
		[JsonProperty("expenses")]
		public bool Expenses { get; set; }
		[JsonProperty("invoices")]
		public bool Invoices { get; set; }
		[JsonProperty("estimates")]
		public bool Estimates { get; set; }
		[JsonProperty("approval")]
		public bool Approval { get; set; }
	}
}