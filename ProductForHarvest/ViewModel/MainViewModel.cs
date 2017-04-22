using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using ProduceForHarvest.Model;

namespace ProduceForHarvest.ViewModel
{
	public class MainViewModel : ViewModelBase
	{
		private readonly IDataService _dataService;
		private readonly INavigationService _navigationService;


		public MainViewModel(IDataService dataService,INavigationService navigationService)
		{
			_dataService = dataService;
			_navigationService = navigationService;
			Initialize();
		}


		private async Task Initialize()
		{
			try
			{
				var item = await _dataService.GetData();
				//var whoami = await _dataService.WhoAmI();
				var daily = await _dataService.Daily();
				//var projects = await _dataService.Projects();
				var project = await _dataService.Project(11851765);
			}
			catch (Exception ex)
			{
				// Report error here
			}
		}
	}
}