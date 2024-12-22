using System.ComponentModel.DataAnnotations.Schema;

namespace Platforma.Models
{
    [Table("location")]
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
