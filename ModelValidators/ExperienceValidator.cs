namespace CVBuilder.ModelsValidators;

public class ExperienceValidator : AbstractValidator<Experience>
{
    public ExperienceValidator()
    {
        RuleFor(x => x.LocationName).NotEmpty().WithMessage("Work Place Name required.")
            .MaximumLength(50).WithMessage("Maximum Length is 50 letter");
        RuleFor(x => x.JobTitle).NotEmpty().WithMessage("Job Title required.")
            .MaximumLength(50).WithMessage("Maximum Length is 50 letter");
        RuleForEach(x => x.Data).SetValidator(new DataValidator());
        RuleFor(x => x.Date).SetValidator(new DateValidator());
    }
}

