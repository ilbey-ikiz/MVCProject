namespace MVCProject.Entities.Concrete
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreationTime = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
