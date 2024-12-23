using System.ComponentModel.DataAnnotations.Schema;

namespace Platforma.Models
{
    [Table("listings")]
    public class Listing
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Title { get; set; }
        [Column("description")] 
        public string Description { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("published_at")] 
        public DateTime PublishedAt { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("item_id")]
        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        [Column("locationid")]
        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }
    }
}
