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
        public DateTime OfferPlaced { get; set; }
        //[Required]
        //public DateTime? OfferFullfilled { get; set; }
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public Supplier Supplier { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int RequestID { get; set; }
    }
}
