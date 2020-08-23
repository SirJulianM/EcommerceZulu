using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceZulu.web.Models
{
    public class CategoryViewModel
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public Guid ImageId { get; internal set; }
    }
}
