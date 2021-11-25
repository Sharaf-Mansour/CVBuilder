namespace CVBuilder.Models;
public class References  : PersonalDataModel, ICloneable, IValidation
{
    public string? WorkPlace { get; set; }
     public string? JobTitle { get; set; }
    object ICloneable.Clone() => this.DeepClone();
    public override bool IsValid() => new ReferncesValidator().Validate(this).IsValid;
}