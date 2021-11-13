namespace CVBuilder.Models;
public class Education : ICloneable, IValidation
{
    public virtual string? LocationName { get; set; }
    public string? Year { get; set; }
   
    public List<Data>? Data { get; set; } = new();
   public bool IsValid() => !string.IsNullOrWhiteSpace(LocationName) && !string.IsNullOrWhiteSpace(Year);
    public bool InEditState { get; set; }
    object ICloneable.Clone() => new Education() { LocationName = this.LocationName, Year = this.Year, Data = this.Data }; 
}

public class EducationValidator : AbstractValidator<Education>
{
    public EducationValidator()
    {
        RuleFor(x => x.LocationName).NotEmpty().WithMessage("School Name required.")
            .MaximumLength(50).WithMessage("Maxmum Length is 50 letter");
        RuleFor(x => x.Year).NotEmpty().WithMessage("Year required.")
            .MaximumLength(30).WithMessage("Maxmum Length is 30 letter");

    }
}