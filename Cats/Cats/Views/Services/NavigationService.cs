using System.Threading.Tasks;
using Xamarin.Forms;
using Cats.ViewModels.Services;

namespace Cats.Views.Services
{
    public class NavigationService : INavigationService 
	{
		#region INavigationService implementation

		public async Task NavigateToDetail(Models.Cat selectedCat)
		{
			await Application.Current.MainPage.Navigation.PushAsync (new DetailsPage(selectedCat));
		}

		#endregion
	}
}
