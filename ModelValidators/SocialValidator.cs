namespace CVBuilder.ModelsValidators;
public class SocialValidator : AbstractValidator<Social>
{
    public SocialValidator()
    {
        RuleFor(x => x.PlatformlName)
            .NotEmpty().WithMessage("Platforml Name is required.")
            .MaximumLength(50).WithMessage("Maximum Length is 50 letter");
        RuleFor(x => x.UserName).SetValidator(new DataValidator());
    }
}