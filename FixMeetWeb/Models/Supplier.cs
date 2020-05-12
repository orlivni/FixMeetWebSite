using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FixMeetWeb.Models
{
    public class Supplier
    {
        [Key]
        [HiddenInput(DisplayValue = true)]
        [Display(Name = "Supplier ID")]
        [Required(ErrorMessage = "This field is required")]
        public int SupplierID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }

        [Display(Name = "Confirm Email")]
        [DataType(DataType.EmailAddress)]
        [Compare("Email", ErrorMessage = "The Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "This field is required")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The Password and Confirm Password must match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "This field is required")]
        public string Address { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "This field is required")]
        public Category Category { get; set; }

        /* [Display(Name = "Address")]
         [Required(ErrorMessage = "This field is required")]
         public Address Address { get; set; }

         [Display(Name = "Category")]
         [Required(ErrorMessage = "This field is required")]
         public Category Category { get; set; }*/

        [Display(Name = "Radius")]
        [Required(ErrorMessage = "This field is required")]
        public int Radius { get; set; }
    }
}
