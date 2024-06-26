﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WeGapApi.Models.Dto
{
    public class UpdateEmployeeDto
    {
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        public int Pincode { get; set; }
        [Required(ErrorMessage = "Mobile Number is a required !!")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile Number must be exactly 10 digits.")]
        public string MobileNumber { get; set; }
        public string Bio { get; set; }
        public IFormFile Imagefile { get; set; }
        public string ImageName { get; set; }
    }

}