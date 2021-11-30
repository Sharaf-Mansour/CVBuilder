namespace CVBuilder.ModelsValidators;
public class CertificateValidator : AbstractValidator<Certificate>
{
    public CertificateValidator()
    {
        RuleFor(x => x.Date).SetValidator(new DateValidator());
        RuleFor(x => x.Data).SetValidator(new DataValidator());
    }
}