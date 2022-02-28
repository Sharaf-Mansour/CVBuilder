namespace CVBuilder.Models;
public class Education : IValidation
{
    public string? LocationName { get; set; }
    public List<Data>? Data { get; set; } = new();
    public virtual bool IsValid() => new EducationValidator().Validate(this).IsValid;
    public bool InEditState { get; set; }
    public DateModel Date { get; set; } = new();
}