using Prism;
using Prism.Ioc;
using EcommerceZulu.Prism.ViewModels;
using EcommerceZulu.Prism.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using EcommerceZulu.Common.Services;
using Syncfusion.Licensing;

namespace EcommerceZulu.Prism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("MjExMTY0QDMxMzcyZTM0MmUzMEc1K2xKbkhrV2RmMHByRXF6YUJDQlQ3RkxLZ3hxOVlyMHY0T1RiSUFEZUk9");
            InitializeComponent();
            await NavigationService.NavigateAsync($"NavigationPage/{nameof(ProductPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductPage, ProductPageViewModel>();
        }
    }
}
