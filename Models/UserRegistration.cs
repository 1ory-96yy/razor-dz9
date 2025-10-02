using System.ComponentModel.DataAnnotations;

public class UserRegistration
{
    [Required]
    public string Name { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required, StringLength(100, MinimumLength = 6)]
    public string Password { get; set; }
}