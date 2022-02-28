namespace CVBuilder.Models;
public class Experience : Education, IValidation
{
    public string? JobTitle { get; set; }
    public override bool IsValid() => new ExperienceValidator().Validate(this).IsValid;
}