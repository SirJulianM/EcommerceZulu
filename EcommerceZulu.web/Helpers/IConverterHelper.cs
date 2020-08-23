using EcommerceZulu.Common.Entities;
using EcommerceZulu.web.Models;
using System;
using System.Threading.Tasks;

namespace EcommerceZulu.web.Helpers
{
    public interface IConverterHelper
    {
        Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

        CategoryViewModel ToCategoryViewModel(Category category);

        Task<Product> ToProductAsync(ProductViewModel model, bool isNew);

        ProductViewModel ToProductViewModel(Product product);

    }
}
