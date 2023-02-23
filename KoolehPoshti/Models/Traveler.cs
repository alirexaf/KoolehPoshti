using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoolehPoshti.Models
{
    public class Traveler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Source { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public DateTime TravelDate { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string TelegramId { get; set; }
        public string WhatsAppNumnber { get; set; }




    }
}
