using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceZulu.web.Models
{
    public class CategoryViewModel
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public Guid ImageId { get; set; }
    }
}
