using System.ComponentModel.DataAnnotations;
namespace DomainLayer.Models
{
    public class Resultss : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string? ResultStatus { get; set; }

        public int StudentId { get; set; }

        public Student Students { get; set; }

    }
}