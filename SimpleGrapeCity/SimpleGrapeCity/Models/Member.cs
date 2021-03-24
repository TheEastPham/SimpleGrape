using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleGrapeCity.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy}")]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        
        public GenderType Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        [RegularExpression("^[0]{1}[0-9]{9}$",
            ErrorMessage ="Phone Numeber must be 10 digits and start by 0.")]
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
        public string QRUrl { get; set; }

    }
    public enum GenderType
    {
        Male,
        Fmale
    }
}
