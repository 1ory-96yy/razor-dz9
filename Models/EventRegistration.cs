using System.ComponentModel.DataAnnotations;

public class EventRegistration
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [Range(18, 65, ErrorMessage = "Вік має бути від 18 до 65")]
    public int Age { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
