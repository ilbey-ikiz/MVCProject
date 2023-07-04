using MVCProject.Entities.Enums;

namespace MVCProject.Entities.Concrete
{
    public class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Storage> Storages { get; set; }


    }
}
