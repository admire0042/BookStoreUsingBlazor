using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookAppBlazor.Data
{
    public class Publisher
    {
        public string PublisherId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Publisher_Name { get; set; }
       
        [StringLength(20, ErrorMessage = "City name can not be longer than 20 char")]
        public string City { get; set; }
        //[DataType(DataType.EmailAddress)]
        //[EmailAddress(ErrorMessage = "Please enter valid email address")]
        //public string Email { get; set; }
        //[Range(1000, 99999999, ErrorMessage = "Salary should be greater than $1000")]
        //public int Salary { get; set; }

        public Publisher()
        {

        }
        public Publisher(string publisherId, string publisher_Name, string city)
        {
            PublisherId = publisherId;
            Publisher_Name = publisher_Name;
            City = city;
        }
    }
}
