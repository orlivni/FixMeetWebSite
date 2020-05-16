using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FixMeetWeb.Models
{
    public class Request
    {
        [Key]
        public int RequestID { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public DateTime RequestDate { get; set; }

        [Required]
        public Category Category { get; set; }

        public string Description { get; set; }

        public ICollection<Offer> OffersFromSuppliers { get; set; }

        public Booking? Booking { get; set; } //refernce to booking if exists, else will be NULL
    }
}
