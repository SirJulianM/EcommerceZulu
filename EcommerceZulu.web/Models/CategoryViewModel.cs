using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EcommerceZulu.web.Models
{
    public class CategoryViewModel
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

    }
}
