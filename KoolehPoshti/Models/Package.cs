using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoolehPoshti.Models
{
    public class Package
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public string Dimension { get; set; }
        [Required]
        public virtual PackageCategory Category { get; set; }
        [Required]
        public virtual ICollection<PackageImage> Images { get; set; }
        [Required]
        public bool IsVisible { get; set; }


    }
}
