using System;
using System.ComponentModel.DataAnnotations;

public class NotFutureDateAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value is DateTime date)
        {
            return date <= DateTime.Now;
        }
        return true;
    }

    public override string FormatErrorMessage(string name)
    {
        return "Дата не може бути у майбутньому";
    }
}
