﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EcommerceZulu.web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboCategories();

        IEnumerable<SelectListItem> GetComboCountries();

        IEnumerable<SelectListItem> GetComboDepartments(int countryId);

        IEnumerable<SelectListItem> GetComboCities(int departmentId);

    }
}
