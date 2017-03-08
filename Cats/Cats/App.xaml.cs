using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Cats.Views;

namespace Cats
{
	public partial class App : Application
	{
		public App()
		{
			DependencyService.Register<ViewModels.Services.IMessageService, Views.Services.MessageService>();
			DependencyService.Register<ViewModels.Services.INavigationService, Views.Services.NavigationService>();
			MainPage = new NavigationPage(new CatsPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
			MobileCenter.Start("android=17e8ed2d-61fa-407c-8e58-99e50e650e5e;" +
							   "ios=492c51ef-2049-455f-bc82-1f4fe6b0cba5;",
							   typeof(Analytics), typeof(Crashes));
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
