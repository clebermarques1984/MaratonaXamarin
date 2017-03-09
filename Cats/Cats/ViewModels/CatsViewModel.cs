using System;
using System.Threading.Tasks;
using Cats.Models;
using MvvmHelpers;
using Xamarin.Forms;

namespace Cats.ViewModels
{
	public class CatsViewModel : ObservableObject
	{
		readonly Services.INavigationService navigationService;

		readonly Services.IMessageService messageService;

		public Command GetCatsCommand { get; }

		public ObservableRangeCollection<Cat> Cats { get; set; }
	
		Cat selectedCat;
		public Cat SelectedCat
		{
			get { return selectedCat; }
			set
			{
				if (SetProperty(ref selectedCat, value))
				{
					ShowDetail();
				};
			}
		}

		bool isBusy;
		public bool IsBusy
		{
			get { return isBusy; }
			set
			{
				if (SetProperty(ref isBusy, value))
				{
					GetCatsCommand.ChangeCanExecute();
				};
			}
		}

		public CatsViewModel()
		{
			Cats = new ObservableRangeCollection<Cat>();

			GetCatsCommand = new Command(async () => await GetCats(), () => !IsBusy);

			navigationService = DependencyService.Get<Services.INavigationService>();

			messageService = DependencyService.Get<Services.IMessageService>();
		}

		async Task ShowDetail()
		{
			if (selectedCat != null)
			{
				await navigationService.NavigateToDetail(selectedCat);
				SelectedCat = null;
			}
		}

		async Task GetCats()
		{
			if (!IsBusy)
			{
				Exception Error = null;
				try
				{
					IsBusy = true;
					var repository = new Repository();
					var items = await repository.GetCats();
					Cats.Clear();
					Cats.AddRange(items);
				}
				catch (Exception ex)
				{
					Error = ex;
				}
				finally
				{
					if (Error != null)
					{
						await messageService.ShowOkAsync("Error!", Error.Message);
					}
					IsBusy = false;
				}
			}
			return;
		}
	}
}
