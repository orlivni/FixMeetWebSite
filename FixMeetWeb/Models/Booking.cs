using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FixMeetWeb.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public Offer Offer { get; set; }
        [Required]
        public int OfferID { get; set; }

        [Required]
        public Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public Supplier Supplier { get; set; }
        [Required]
        public int SupplierId { get; set; }

    }
}
