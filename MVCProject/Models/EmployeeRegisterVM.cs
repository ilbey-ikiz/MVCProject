using MVCProject.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class EmployeeRegisterVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
       
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Sifreler Eslesmiyor")]
        public string PasswordConfirm { get; set; }
    }
}
