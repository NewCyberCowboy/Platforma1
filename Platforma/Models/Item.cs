using System.ComponentModel.DataAnnotations.Schema;

namespace Platforma.Models
{
    public class Item
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<CategoryItem> CategoryItems { get; set; }
    }
}
