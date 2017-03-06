using Cats.ViewModels;
using Xamarin.Forms;

namespace Cats.Views
{
	public partial class CatsPage : ContentPage
	{
		public CatsPage()
		{
			InitializeComponent();
			BindingContext = new CatsViewModel();
		}
	}
}
