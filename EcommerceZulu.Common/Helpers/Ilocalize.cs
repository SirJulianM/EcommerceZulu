using System.Globalization;

namespace EcommerceZulu.Common.Helpers
{
    public interface Ilocalize
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale(CultureInfo ci);

    }
}
