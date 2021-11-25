namespace CVBuilder.ModelsValidators;
public class DataValidator : AbstractValidator<Data>
{
    public DataValidator()
    {
        RuleFor(x => x.Value)
            .NotEmpty().WithMessage("Please enter Data")
            .MaximumLength(70).WithMessage("Maxmum Length is 70 letter");
        RuleFor(x => x.Link)
            .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _))
            .When(x => x.IsLink)
            .WithMessage("Link is not in the correct format Try starting with Http:// or Https://");
    }
}