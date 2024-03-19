using System.ComponentModel.DataAnnotations;

namespace MainProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DataOfBirth { get; set; }
        public byte[] Image { get; set; }
        public string MobilePhone { get; set; }
        public string Gender { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(8)]
        [MaxLength(100)]
        public string Password { get; set; }
        public string Address { get; set; }




    }
}
