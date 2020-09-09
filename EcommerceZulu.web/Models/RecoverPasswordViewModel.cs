﻿using System.ComponentModel.DataAnnotations;

namespace EcommerceZulu.web.Models
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
