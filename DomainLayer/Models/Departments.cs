namespace DomainLayer.Models
{
    public class Departments : BaseEntity
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        public int StudentId { get; set; }

        public Student Students { get; set; }

    }
}