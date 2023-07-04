namespace MVCProject.Entities.Concrete;

public class Company:BaseEntity
{
    public string CompanyName { get; set; }
    public string Sector { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public ICollection<Employee> Employees { get; set; }
}
