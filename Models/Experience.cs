namespace CVBuilder.Models;
public class Experience : Education, ICloneable, IValidation
{
    public string? JobTitle { get; set; }
    object ICloneable.Clone() => this.DeepClone();
    public override bool IsValid() => new ExperienceValidator().Validate(this).IsValid;
}