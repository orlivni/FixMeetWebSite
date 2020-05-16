using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FixMeetWeb.Models
{
    public class Offer
    {
        [Key]
        public int OfferID { get; set; }

        [Required]
        public Request Request { get; set; }
        [Required]
        public int RequestID { get; set; }

        [Required]
        public Supplier Supplier { get; set; }
        [Required]
        public int SupplierId { get; set; }

        [Required]
        public DateTime OfferDate { get; set; }

        [Required]
        public string Description { get; set; }

        public Booking Booking { get; set; } //refernce to booking if exists, else will be NULL
    }
}
