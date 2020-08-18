using System.ComponentModel.DataAnnotations;

namespace EcommerceZulu.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} must contained less than {1} characteres.")]
        public string Name { get; set; }

    }
}
