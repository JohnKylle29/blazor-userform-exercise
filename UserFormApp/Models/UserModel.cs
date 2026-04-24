//1st i created this
using System.ComponentModel.DataAnnotations;

namespace UserFormApp.Models
{
    public class UserModel
    {
        [Required]
        public string UserName { get; set; }

        public string UserAddress { get; set; }

        public int? Age { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}