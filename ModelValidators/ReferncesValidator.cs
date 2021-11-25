namespace CVBuilder.Models;

public class ReferncesValidator : AbstractValidator<References >
{
    public ReferncesValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name required.")
            .MaximumLength(40).WithMessage("Maxmum Length is 40 letter");
        RuleFor(x => x.WorkPlace).NotEmpty().WithMessage("Please Enter The Work Place")
            .MaximumLength(40).WithMessage("Maxmum Length is 40 letter");
        RuleFor(x => x.JobTitle).NotEmpty().WithMessage("Please Enter The Job Title")
            .MaximumLength(40).WithMessage("Maxmum Length is 40 letter");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email required.")
            .MaximumLength(40).WithMessage("Not allowed for more than 40 Letter ")
            .EmailAddress().WithMessage("Format of mail is not correct");
        RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is required")
            .MaximumLength(15).WithMessage("Max Length is 15 number");
    }
}