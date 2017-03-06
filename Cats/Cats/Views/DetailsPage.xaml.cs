using System;
using Cats.Models;
using Xamarin.Forms;

namespace Cats.Views
{
	public partial class DetailsPage : ContentPage
	{
		Cat selectedCat;
		public DetailsPage(Cat selectedCat)
		{
			InitializeComponent();
			this.selectedCat = selectedCat;
			BindingContext = this.selectedCat;
			ButtonWebSite.Clicked += ButtonWebSite_Clicked;
		}

		void ButtonWebSite_Clicked(object sender, EventArgs e)
		{
			if (selectedCat.WebSite.StartsWith("http", StringComparison.CurrentCulture))
			{
				Device.OpenUri(new Uri(selectedCat.WebSite));
			}
		}
	}
}
