namespace CVBuilder.ModelsValidators;
public class SkillValidator : AbstractValidator<Skill>
{
    public SkillValidator()
    {
        RuleFor(x => x.SkillType)
            .NotEmpty().WithMessage("Skill Type is required.")
            .MaximumLength(50).WithMessage("Maximum Length is 50 letter");
        RuleForEach(x => x.Data).SetValidator(new DataValidator());
    }
}