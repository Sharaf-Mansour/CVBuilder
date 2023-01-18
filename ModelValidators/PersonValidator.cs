namespace CVBuilder.ModelsValidators;
public class PersonValidator : AbstractValidator<PersonalDataModel>
{
    public PersonValidator()
    {
        RuleFor(x => x.Name)
          .NotEmpty().WithMessage("Name required.")
          .MaximumLength(55).WithMessage("Maximum Length is 55 Letters");
        RuleFor(x => x.BirthDate)
           .Must(x => (x < DateTime.Now && x is not null) || x is null).WithMessage("Date of birth is not valid"); 
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email required.")
            .MaximumLength(50).WithMessage("Not allowed for more than 50 Letters");
        RuleFor(x => x.Email)
            .EmailAddress().When(x => !string.IsNullOrWhiteSpace(x.Email))
            .WithMessage("Format of mail is not correct");
        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("Phone is required")
            .MaximumLength(15).WithMessage("Maximum Length is 15 number");
        RuleFor(x => x.Phone)
            .Matches(@"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$")
            .When(x => !string.IsNullOrWhiteSpace(x.Phone))
            .WithMessage(x => $"{x.Phone} is not a valid phone number.");
        RuleFor(x => x.Address).SetValidator(new AddressValidator());
        RuleFor(x => x.Summary).MaximumLength(2000).WithMessage("Maximum Length is 2000 Letters");
        RuleFor(x => x.Summary).Must(x => x ?.Split(Environment.NewLine.ToCharArray()).Max(x => x.Length) <= 100).When(x=> !string.IsNullOrWhiteSpace(x.Summary)).WithMessage("Maximum Length of line is 100 Letters");
        RuleFor(x => x.Summary).Must(x => x?.Split(Environment.NewLine.ToCharArray()).Length <= 20).When(x => !string.IsNullOrWhiteSpace(x.Summary)).WithMessage("Maximum rows count is 20");
    }
}