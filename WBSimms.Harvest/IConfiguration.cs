namespace WBSimms.Harvest
{
	public interface IConfiguration
	{
		string CompanyName { get; set; }
		string Password { get; set; }
		string UserName { get; set; }
	}
}