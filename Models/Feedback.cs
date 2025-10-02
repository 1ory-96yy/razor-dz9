using System.ComponentModel.DataAnnotations;

public class Feedback
{
    [Required]
    public string Title { get; set; }

    [Required]
    public string Message { get; set; }
}
