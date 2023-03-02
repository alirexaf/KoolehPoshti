using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoolehPoshti.Models
{
    public class Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public bool IsAccepted { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime TimeCreated { get; set; }
        public int RequesterId { get; set; }
        public virtual Requester Requester { get; set; }
        public int TravelerId { get; set; }
        public virtual Traveler Traveler { get; set; }
        public int PackageId { get; set; }
        public virtual Package Package { get; set; }
    }
}
