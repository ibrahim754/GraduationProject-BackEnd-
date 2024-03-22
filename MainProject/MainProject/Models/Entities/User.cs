using System.ComponentModel.DataAnnotations;

namespace MainProject.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        [EmailAddress]
        public string Email { get; set; } 
        [MinLength(8)]
        [MaxLength(50)]
        public string Password { get; set; }
        public string Address { get; set; }

        public DateTime DataOfBirth { get; set; }
        public byte[] Image { get; set; }


    }
}
