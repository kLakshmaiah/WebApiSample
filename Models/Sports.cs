﻿using DataAnnotationsExtensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Sports
    {
        [Required(ErrorMessage = "{0} is required")]
        //[Min(2,ErrorMessage ="{0} value is minimum {1}")]
        //[Max(10,ErrorMessage ="{0} value is Maximum {1}")]
        [Range(2, 10, ErrorMessage = "{0} having minumum value is {1}  and Maximum value {2}")]
        public int? Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "{0} having  {1} characters only")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "{0}  Contains only Alphabets")]
        public string? SportName { get; set; }
        public int? NumberOfPlayers { get; set; }
        //[StringLength(10, MinimumLength = 10, ErrorMessage = "{0} having  {1} numbers only")]
        //[Phone(ErrorMessage = "{0} having 10 digits only.")]
        //[RegularExpression("^[7-9]\\d{9}$", ErrorMessage = "Mobile Number Contains only number")]
        //[DataType(DataType.PhoneNumber)]
        //public long? Phonumber { get; set; }

        [Phone(ErrorMessage = "{0} should contain 10 digits")]
        //[ValidateNever]
        public string? Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Invalid {0}")]
        public string? EmailId { get; set; }
        //[Min(2012,ErrorMessage ="Joinging Year must be 2012 or above")]
        public DateTime JoiningDate { get; set; }
       
        public double Year1 { get; set; }
        [Compare("Year1", ErrorMessage = " year1 and year must be same")]
        public double Year { get; set; }
    }
}
