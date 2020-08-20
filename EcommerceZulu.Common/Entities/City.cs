using System.ComponentModel.DataAnnotations;

namespace EcommerceZulu.Common.Entities
{
    public class City
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "The field {0} must contained less than {1} characteres.")]
        [Required]
        public string Name { get; set; }

    }
}
