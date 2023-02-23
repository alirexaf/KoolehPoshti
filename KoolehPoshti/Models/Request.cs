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
        [ForeignKey("Id")]
        public Traveler Traveler { get; set; }
        [Required]
        [ForeignKey("Id")]
        public Requester Requester { get; set; }
        [Required]
        public bool IsAccepted { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime TimeCreated { get; set; }   
    }
}
