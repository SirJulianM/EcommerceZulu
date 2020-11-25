using EcommerceZulu.Common.Entities;
using EcommerceZulu.Prism.Views;
using Prism.Commands;
using Prism.Navigation;

namespace EcommerceZulu.Prism.ItemViewModel
{
    public class ProductItemViewModel : Product
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectProductCommand;

        public ProductItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectProductCommand => _selectProductCommand ?? (_selectProductCommand = new DelegateCommand(SelectProductAsync));

        private async void SelectProductAsync()
        {
            NavigationParameters parameters = new NavigationParameters
            {
                { "product", this }
            };

            await _navigationService.NavigateAsync(nameof(ProductDetailPage), parameters);
        }

    }
}
