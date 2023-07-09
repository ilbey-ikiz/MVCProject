using MVCProject.Entities.Concrete;
using MVCProject.Entities.Enums;

namespace MVCProject.Models
{
    public class StorageVM
    {
        public EmployeeType EmployeeType { get; set; }
        public List<Storage> Storages { get; set; }
    }
}
