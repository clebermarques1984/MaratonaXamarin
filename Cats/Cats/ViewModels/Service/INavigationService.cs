using System.Threading.Tasks;

namespace Cats.ViewModels.Services
{
	public interface INavigationService
	{
		Task NavigateToDetail(Models.Cat selectedCat);
	}
}
