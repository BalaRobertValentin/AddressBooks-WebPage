
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication4.Models
{
    public class AddressBooks
    {

        public int ID
        {
            get; set;
        }
        [MaxLength(20)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName
        { 
            get; set;

        }
        [MaxLength(20)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName
        {
            get; set;
        }
        [MaxLength(15)]
        [Required]
        [Display(Name = "Phone")]
        public string PhoneNumber
        {
            get; set;
        }
        [MaxLength(50)]
        [Required]
        [Display(Name = "Address")]
        public string Address { 
            get; set;
        }
        [MaxLength(20)]
        [Required]
        [Display(Name = "City")]
        public string City
        {
            get; set;
        }
        [MaxLength(20)]
        [Required]
        [Display(Name = "State")]
        public string State
        {
            get; set;
        }
        [MaxLength(20)]
        [Required]
        [Display(Name = "Country")]
        public string Country
        {
            get; set;
        }
        [MaxLength(10)]
        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode
        {
            get; set;
        }
        [MaxLength(50)]
        [Required]
        [Display(Name = "Email")]
        public string Email
        {
            get; set;
        }
        [Display(Name = "Date")]
        public DateTime CreatedDate
        {
            get; set;
        }
        }
}