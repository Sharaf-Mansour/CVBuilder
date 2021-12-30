namespace CVBuilder.ModelsValidators;
public class PersonValidator : AbstractValidator<PersonalDataModel>
{
    public PersonValidator()
    {
        RuleFor(x => x.Name)
          .NotEmpty().WithMessage("Name required.")
          .MaximumLength(55).WithMessage("Maximum Length is 55 Letters");
        RuleFor(x => x.BirthDate)
           .Must(x => (x < DateTime.Now && x is not null) || x is null).WithMessage("Date of birth is not vaild");
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email required.")
            .MaximumLength(50).WithMessage("Not allowed for more than 50 Letters")
            .EmailAddress().WithMessage("Format of mail is not correct");
        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("Phone is required")
            .MaximumLength(15).WithMessage("Maximum Length is 15 number")
            .Matches(@"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$")
            .WithMessage(x => $"{x.Phone} is not a valid phone number.");
        RuleFor(x => x.Address).SetValidator(new AddressValidator());
    }
}