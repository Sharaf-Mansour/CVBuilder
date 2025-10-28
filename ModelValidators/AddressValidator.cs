namespace CVBuilder.ModelValidators;
public class AddressValidator : AbstractValidator<AddressModel>
{
    public AddressValidator()
    {
        RuleFor(x => x.Country).SetValidator(new CountryValidator());
        RuleFor(x => x.Street)
            .MaximumLength(50).WithMessage("Not allowed for more than 50 Letters");
        RuleFor(x => x.ZIPCode)
            .MaximumLength(12).WithMessage("Maximum Length is 12")
            .Matches(@"^((\d{5}-\d{4})|(\d{5})|([A-Z]\d[A-Z]\s\d[A-Z]\d))$").When(x => !string.IsNullOrEmpty(x.ZIPCode))
            .WithMessage(x => $"{x.ZIPCode} is not a valid ZIP Code.");
    }
}