namespace MVCProject.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public Product()
        {
            Columns = new HashSet<Column>();
        }
        public string ProductName { get; set; }
        //public ICollection<Storage> Storage { get; set; }
        public ICollection<Column> Columns { get; set; }
    }
}
