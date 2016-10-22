using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WBSimms.Harvest.Models
{
	public class Daily
	{
		[JsonProperty("day_entries")]
		public List<DayEntry> DayEntries { get; set; }
		[JsonProperty("for_day")]
		public string ForDay { get; set; }

	}

	public class DayEntry
	{
		[JsonProperty("project_id")]
		public string ProjectId { get; set; }
		[JsonProperty("project")]
		public string Project { get; set; }
		[JsonProperty("user_id")]
		public int UserId { get; set; }
		[JsonProperty("spent_at")]
		public DateTime SpentAt { get; set; }
		[JsonProperty("task_id")]
		public string TaskId { get; set; }
		[JsonProperty("task")]
		public string Task { get; set; }
		[JsonProperty("client")]
		public string Client { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("notes")]
		public string Notes { get; set; }
		[JsonProperty("started_at")]
		public string StartedAt { get; set; }
		[JsonProperty("ended_at")]
		public string EndedAt { get; set; }
		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }
		[JsonProperty("updated_at")]
		public DateTime UpdatedAt { get; set; }
		[JsonProperty("hours_without_timer")]
		public decimal HoursWithoutTimer { get; set; }
		[JsonProperty("hours")]
		public decimal Hours { get; set; }


	}
}
