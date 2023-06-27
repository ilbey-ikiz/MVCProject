namespace MVCProject.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public ICollection<Storage> Storage { get; set; }
        public ICollection<Column> Column { get; set; }
    }
}
