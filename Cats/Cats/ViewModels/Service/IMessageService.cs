using System.Threading.Tasks;

namespace Cats.ViewModels.Services
{
	public interface IMessageService
	{
		Task<bool> ShowQuestionAsync(string title, string message);

		Task ShowOkAsync(string title, string message);
	}
}
