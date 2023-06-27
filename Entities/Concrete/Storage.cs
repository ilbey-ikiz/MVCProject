namespace MVCProject.Entities.Concrete
{
    public class Storage:BaseEntity
    {
        public string StorageName { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Column> Columns { get; set; }
        //public ICollection<Employee> Employees { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
