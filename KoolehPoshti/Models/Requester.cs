using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoolehPoshti.Models
{
    public class Requester
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set;}
        [Required]
        public string PhoneNumber { get; set;}
        [Required]
        public string Email { get; set;}
        public string TelegramId { get; set; }
        public string WhatsAppNumnber { get; set; }
    }
}
