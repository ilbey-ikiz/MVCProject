namespace MVCProject.Entities.Concrete
{
    public class Column : BaseEntity
    {
        public Column()
        {
            Storages = new HashSet<Storage>();
            Products = new HashSet<Product>();
        }
        public string ColumnName { get; set; }
        public ICollection<Storage> Storages { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
