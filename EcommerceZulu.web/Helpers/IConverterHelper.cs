using EcommerceZulu.Common.Entities;
using EcommerceZulu.web.Models;
using System;

namespace EcommerceZulu.web.Helpers
{
    public interface IConverterHelper
    {
        Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

        CategoryViewModel ToCategoryViewModel(Category category);

    }
}
