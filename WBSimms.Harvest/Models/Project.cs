using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace WBSimms.Harvest.Models
{
	public class Projects
	{
		[JsonProperty("project")]
		public Project Project { get; set; }
	}

	public class Project
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("client_id")]
		public int ClientId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("code")]
		public string Code { get; set; }
		[JsonProperty("active")]
		public bool Active { get; set; }
		[JsonProperty("billable")]
		public bool Billable { get; set; }
		[JsonProperty("bill_by")]
		public string BillBy { get; set; }
		[JsonProperty("hourly_rate")]
		public string HourlyRate { get; set; }
		[JsonProperty("budget")]
		public int? Budget { get; set; }
		[JsonProperty("budget_by")]
		public string BudgetBy { get; set; }
		[JsonProperty("notify_when_over_budget")]
		public bool NotifyWhenOverBudget { get; set; }
		[JsonProperty("over_budget_notification_percentage")]
		public decimal OverBudgetNotificationPercentage { get; set; }
		[JsonProperty("over_budget_notified_at")]
		public string OverBudgetNotifiedAt { get; set; }
		[JsonProperty("show_budget_to_all")]
		public bool ShowBudgetToAll { get; set; }
		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }
		[JsonProperty("updated_at")]
		public DateTime UpdatedAt { get; set; }
		[JsonProperty("starts_on")]
		public string StartsOn { get; set; }
		[JsonProperty("ends_on")]
		public string EndsOn { get; set; }
		[JsonProperty("estimate")]
		public int? Estimate { get; set; }
		[JsonProperty("estimate_by")]
		public string EstimateBy { get; set; }
		[JsonProperty("hint_earliest_record_at")]
		public DateTime? HintEarliestRecordAt { get; set; }
		[JsonProperty("hint_latest_record_at")]
		public DateTime? HintLatestRecordAt { get; set; }
		[JsonProperty("notes")]
		public string Notes { get; set; }
		[JsonProperty("cost_budget")]
		public decimal? CostBudget { get; set; }
		[JsonProperty("cost_budget_include_expenses")]
		public bool CostBudgetIncludeExpenses { get; set; }
	}
}
