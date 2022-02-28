namespace CVBuilder.Models;
public class Certificate : IValidation
{
    public Data Data { get; set; } = new();
    public DateModel Date { get; set; } = new();
    public bool InEditState { get; set; }
    public bool IsValid() => new CertificateValidator().Validate(this).IsValid;
}