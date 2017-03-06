using System.Threading.Tasks;
using Cats.ViewModels.Services;
using Xamarin.Forms;

namespace Cats.Views.Services
{
	public class MessageService : IMessageService
	{
		#region IMessageService implementation

		public async Task<bool> ShowQuestionAsync (string title,string message)
		{
			return await Application.Current.MainPage.DisplayAlert (title, message, "Sim", "Não");
		}

		public async Task ShowOkAsync(string title, string message)
		{
			await Application.Current.MainPage.DisplayAlert(title, message, "Ok");
		}

		#endregion
	}
}
