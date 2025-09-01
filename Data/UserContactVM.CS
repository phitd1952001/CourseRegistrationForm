using System;
using System.ComponentModel.DataAnnotations;
public class UserContactVM
{
    [Required(ErrorMessage = "Full Name is required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be at least 3 characters long.")]
    public string FullName { get; set; }


    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits")]
    public string PhoneNumber { get; set; }

    public string Address { get; set; }

    [Required(ErrorMessage = "Message is required")]
    [StringLength(250, MinimumLength = 10, ErrorMessage = "Message must be at least 10 characters long.")]
    public string Message { get; set; }

[Required(ErrorMessage = "Please select a service.")]
    public string Service { get; set; }

    [Required]
    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting")]
    public bool AcceptTerms { get; set; }
}