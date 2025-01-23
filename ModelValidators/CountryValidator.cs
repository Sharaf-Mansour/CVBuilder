namespace CVBuilder.ModelValidators;
public class CountryValidator : AbstractValidator<Country?>
{
    public CountryValidator()
    {
        RuleFor(x => x!.Id).NotEqual(0).WithMessage("Country required.");
    }
}