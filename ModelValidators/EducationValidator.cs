namespace CVBuilder.Models;

public class EducationValidator : AbstractValidator<Education>
{
    public EducationValidator()
    {
        RuleFor(x => x.LocationName).NotEmpty().WithMessage("School Name required.")
            .MaximumLength(50).WithMessage("Maxmum Length is 50 letter");
        RuleFor(x => x.Year).NotEmpty().WithMessage("Year required.")
            .MaximumLength(30).WithMessage("Maxmum Length is 30 letter");
        RuleForEach(x => x.Data).SetValidator(new DataValidator());
    }
}