using System.ComponentModel.DataAnnotations;

public class ContactForm
{
    [Required]
    public string FullName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(500)]
    public string Message { get; set; }
}
