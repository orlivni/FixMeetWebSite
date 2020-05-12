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
        /*[Required]
        [HiddenInput(DisplayValue = true)]
        [Display(Name = "Created")]
        public DateTime DateCreatedUtc { get; set; } = DateTime.UtcNow;*/
        public DateTime RequestPlaced { get; set; }
        [Required]
        public DateTime? RequestFullfilled { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<Offer> OffersFromSuppliers { get; set; }
        [Required]
        public int ChosenOfferId { get; set; }
    }
}
