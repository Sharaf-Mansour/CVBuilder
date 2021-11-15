namespace CVBuilder.Models;
public class PersonValidator : AbstractValidator<PersonalDataModel>
{
  public PersonValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name required.")
            .MaximumLength(40).WithMessage("Maxmum Length is 40 letter");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email required.")
            .MaximumLength(40).WithMessage("Not allowed for more than 40 Letter ")
            .EmailAddress().WithMessage("Format of mail is not correct");
        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("Phone is required")
            .MaximumLength(15).WithMessage("Max Length is 15 number")
            .Matches(@"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$")
            .WithMessage(x => $"{x.Phone} is not a valid phone number.");
     //   RuleFor(x => x.Date).SetValidator(new DateValidator());
    }
}