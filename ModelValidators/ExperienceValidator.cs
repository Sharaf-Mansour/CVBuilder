namespace CVBuilder.Models;

public class ExperienceValidator : AbstractValidator<Experience>
{
    public ExperienceValidator()
    {
        RuleFor(x => x.LocationName).NotEmpty().WithMessage("Work Place Name required.")
            .MaximumLength(40).WithMessage("Maxmum Length is 40 letter");
        RuleFor(x => x.JobTitle).NotEmpty().WithMessage("Job Title required.")
            .MaximumLength(40).WithMessage("Maxmum Length is 40 letter");
        RuleFor(x => x.Year).NotEmpty().WithMessage("Year is required")
            .MaximumLength(30).WithMessage("maximumlength is 30");
        RuleForEach(x => x.Data).SetValidator(new DataValidator());
    }
}

