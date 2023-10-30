using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Models.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string URL { get; set; }

        [Required]
        public int? DisplayOrder { get; set; }

        [Required]
        public int GroupID { get; set; }

        [ForeignKey("GroupID")]
        public virtual MenuGroups Groups { get; set; }
        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}