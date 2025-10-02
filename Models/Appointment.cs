using System;
using System.ComponentModel.DataAnnotations;

public class Appointment
{
    [Required]
    public string Title { get; set; }

    [NotFutureDate]
    public DateTime Date { get; set; }
}
