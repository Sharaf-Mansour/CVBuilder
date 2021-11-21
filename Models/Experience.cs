namespace CVBuilder.Models;
public class Experience : Education, ICloneable, IValidation
{
    public string? JobTitle { get; set; }
    object ICloneable.Clone() => new Experience() { LocationName = this.LocationName,/* Year = this.Year,*/Date = this.Date, Data = this.Data,JobTitle = this.JobTitle };
    public override bool IsValid() => new ExperienceValidator().Validate(this).IsValid;
}