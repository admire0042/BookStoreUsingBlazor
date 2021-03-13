using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookAppBlazor.Data
{
    public class Author
    {
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        [StringLength(20, ErrorMessage = "City name can not be longer than 20 char")]
        public string City { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter valid email address")]
        public string EmailAddress { get; set; }
        [Range(1000, 99999999, ErrorMessage = "Salary should be greater than $1000")]
        public int Salary { get; set; }



        public Author()
        {

        }
        public Author(int authorId, string firstName, string lastName, string phoneNo, string city, string email, int salary)
        {
            AuthorId = authorId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
            City = city;
            EmailAddress = email;
            Salary = salary;
        }
    }
}
