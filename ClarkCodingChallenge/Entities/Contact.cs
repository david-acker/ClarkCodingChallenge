using System.ComponentModel.DataAnnotations;

namespace ClarkCodingChallenge.Entities
{
    public class Contact
    {
        [Key]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }
    }
}