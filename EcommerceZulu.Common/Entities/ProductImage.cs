﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceZulu.Common.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44398/images/noImage.png"
            : $"https://onsale.blob.core.windows.net/products/{ImageId}";
    }

}
