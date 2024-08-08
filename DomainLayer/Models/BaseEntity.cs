namespace DomainLayer.Models
{
    public class BaseEntity
    {
        public int Id { set; get; }
        public DateTime CreatedDate { set; get; }

        public DateTime ModifiedDate { set; get; }

        public bool IsActive { set; get; }

    }
}