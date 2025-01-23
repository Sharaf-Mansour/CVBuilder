namespace CVBuilder.ModelValidators;
public class ReferncesValidator : AbstractValidator<References>
{
    public ReferncesValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name required.")
            .MaximumLength(50).WithMessage("Maximum Length is 50 letter");
        RuleFor(x => x.WorkPlace)
            .NotEmpty().WithMessage("Please Enter The Work Place")
            .MaximumLength(50).WithMessage("Maximum Length is 50 letter");
        RuleFor(x => x.JobTitle)
            .NotEmpty().WithMessage("Please Enter The Job Title")
            .MaximumLength(50).WithMessage("Maximum Length is 50 letter");
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email required.")
            .MaximumLength(50).WithMessage("Not allowed for more than 50 Letter ")
            .EmailAddress().WithMessage("Format of mail is not correct");
        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("Phone is required")
            .MaximumLength(15).WithMessage("Max Length is 15 number");
        RuleFor(x => x.Data).SetValidator(new DataLinkValidator());
    }
}