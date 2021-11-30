namespace CVBuilder.ModelsValidators;

public class AddressValidator : AbstractValidator<AddressModel>
{
    public AddressValidator()
    {
        RuleFor(x => x.Country).NotEmpty().WithMessage("Country required.");
        RuleFor(x => x.Street)
        //    .NotEmpty().WithMessage("Email required.")
            .MaximumLength(50).WithMessage("Not allowed for more than 50 Letters");
         //   .EmailAddress().WithMessage("Format of mail is not correct");
        RuleFor(x => x.ZIPCode)
            .MaximumLength(12).WithMessage("Maximum Length is 12")
            .Matches(@"^((\d{5}-\d{4})|(\d{5})|([A-Z]\d[A-Z]\s\d[A-Z]\d))$").When(x=> !string.IsNullOrEmpty(x.ZIPCode))
            .WithMessage(x => $"{x.ZIPCode} is not a valid ZIP Code.");
    }
}
