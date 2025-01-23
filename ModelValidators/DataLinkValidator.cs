namespace CVBuilder.ModelValidators;
public class DataLinkValidator : AbstractValidator<DataLink?>
{
    public DataLinkValidator()
    {
        RuleFor(x => x!.Value)
            .NotEmpty().When(x => x!.IsLink).WithMessage("Please enter Data")
            .MaximumLength(100).WithMessage("Maximum Length is 100 letter");
        RuleFor(x => x!.Link)
            .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _))
            .When(x => x!.IsLink)
            .WithMessage("Link is not in the correct format Try starting with Http:// or Https://");
    }
}