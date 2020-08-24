using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceZulu.Common.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} must contained less than {1} characteres.")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44398/images/noimage.png"
            : $"https://onsale.blob.core.windows.net/categories/{ImageId}";
    }

}
