using Xamarin.Forms;
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
