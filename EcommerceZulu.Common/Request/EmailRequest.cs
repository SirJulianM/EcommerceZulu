using System.ComponentModel.DataAnnotations;

namespace EcommerceZulu.Common.Request
{
    public class EmailRequest
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
