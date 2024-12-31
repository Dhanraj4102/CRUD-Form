using System.ComponentModel.DataAnnotations;

namespace CRUDFormBackend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public DateTime Dob { get; set; }
        public string Language { get; set; }
    }
}
