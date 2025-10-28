namespace CVBuilder.Models;
public class DateModel : IValidation
{
    public int? StartYear { get; set; }
    public Months? StartMonth { get; set; }
    public bool NotFinished { get; set; } = true;
    public int? EndYear { get; set; }
    public Months? EndMonth { get; set; }
    public bool IsValid() => new DateValidator().Validate(this).IsValid;
    public bool InEditState { get; set; }
    public string FullDate() => NotFinished ? $"{StartYear} {StartMonth} - Present" : $"{StartYear} {StartMonth}  {(EndYear is null ? $" " : (EndYear, EndMonth) is (null, not null) ? $" " : $"- {EndYear} {EndMonth}")}";
}