namespace MVCProject.Entities.Concrete
{
    public class Column:BaseEntity
    {
        public string ColumnName { get; set; }
        public ICollection<Storage> Storages { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
