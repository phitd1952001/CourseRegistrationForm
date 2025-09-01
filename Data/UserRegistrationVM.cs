using System;
using System.ComponentModel.DataAnnotations;

public class UserRegistrationVM
{
    [Required(ErrorMessage = "Full Name is required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be at least characters long.")]
    public string FullName { get; set; }


    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Please select a Course.")]
    public string Course { get; set; }

    [Required(ErrorMessage = "Study mode is required")]
    public bool? Study { get; set; } = true; // Mặc định Online

    [Required(ErrorMessage = "Please select a start date.")]
    public DateTime DateTime { get; set; }

    [Required(ErrorMessage = "Comment is required")]
    [StringLength(250, MinimumLength = 10 , ErrorMessage = "Comment must be at least 10 characters long.")]
    public string Comment { get; set; }

    [Required(ErrorMessage = "You must accept the terms")]
    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting")]
    public bool AcceptTerms { get; set; }
}