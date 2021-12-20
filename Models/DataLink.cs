namespace CVBuilder.Models;

public class DataLink : Data, ICloneable, IValidation
{
    public override bool IsValid() => new DataLinkValidator().Validate(this).IsValid;
    object ICloneable.Clone() => this.DeepClone();
}
