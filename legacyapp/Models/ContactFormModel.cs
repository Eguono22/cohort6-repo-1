using System.ComponentModel.DataAnnotations;

namespace legacyapp.Models;

public class ContactFormModel
{
    [Required]
    [Display(Name = "Full Name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [Display(Name = "Email Address")]
    public string Email { get; set; } = string.Empty;

    [Phone]
    [Display(Name = "Phone Number")]
    public string? Phone { get; set; }

    [Required]
    [Display(Name = "Subject")]
    public string Subject { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Message")]
    [DataType(DataType.MultilineText)]
    public string Message { get; set; } = string.Empty;
}
