using EcommerceZulu.Common.Helpers;
using EcommerceZulu.Prism.Resources;
using System.Globalization;
using Xamarin.Forms;

namespace EcommerceZulu.Prism.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            CultureInfo ci = DependencyService.Get<Ilocalize>().GetCurrentCultureInfo();
            Resource1.Culture = ci;
            Culture = ci.Name;
            DependencyService.Get<Ilocalize>().SetLocale(ci);
        }

        public static string Culture { get; set; }

        public static string Accept => Resource1.Accept;

        public static string ConnectionError => Resource1.ConnectionError;

        public static string Error => Resource1.Error;
    }

}
