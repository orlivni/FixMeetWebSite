using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FixMeetWeb.Models
{
    public class Customer:User
    {
        //[Key]
        //public int CustomerID { get; set; }
        //[Required]
        //public string FirstName { get; set; }
        //[Required]
        //public string LastName { get; set; }
        //[Required]
        //public string Email { get; set; }
        //[Required]
        //public string UserName { get; set; }
        //[Required]
        //public string Address { get; set; }
        ////public ICollection<Address> Addresses { get; set; }
        
            //FK
        public ICollection<Request> Requests { get; set; }
        

    }
}
