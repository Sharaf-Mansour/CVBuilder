namespace CVBuilder.ModelValidators;
public class ExperienceValidator : AbstractValidator<Experience>
{
    public ExperienceValidator()
    {
        RuleFor(x => x.LocationName)
        .NotEmpty().WithMessage("Name is required.")
        .MaximumLength(50).WithMessage("Maximum Length is 50 letter");
        RuleForEach(x => x.Data).SetValidator(new DataValidator());
        RuleFor(x => x.Date).SetValidator(new DateValidator());
        RuleFor(x => x.JobTitle)
            .NotEmpty().WithMessage("Job Title required.")
            .MaximumLength(50).WithMessage("Maximum Length is 50 letter");
    }
}