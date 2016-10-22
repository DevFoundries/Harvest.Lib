using Windows.UI.Core;
using Windows.UI.Xaml.Navigation;
using ProduceForHarvest.ViewModel;

namespace ProduceForHarvest
{
	public sealed partial class MainPage
	{
		public MainViewModel Vm => (MainViewModel)DataContext;

		public MainPage()
		{
			InitializeComponent();

			SystemNavigationManager.GetForCurrentView().BackRequested += SystemNavigationManagerBackRequested;

		}

		private void SystemNavigationManagerBackRequested(object sender, BackRequestedEventArgs e)
		{
			if (Frame.CanGoBack)
			{
				e.Handled = true;
				Frame.GoBack();
			}
		}

		protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
		{
			base.OnNavigatingFrom(e);
		}
	}
}
