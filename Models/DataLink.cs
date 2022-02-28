namespace CVBuilder.Models;
public class DataLink : Data, IValidation
{
    public override bool IsValid() => new DataLinkValidator().Validate(this).IsValid;
}