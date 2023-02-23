using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoolehPoshti.Models
{
    public class PackageImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public byte[] Data { get; set; }
        [ForeignKey("Id")]
        public Package Package { get; set; }
    }
}
