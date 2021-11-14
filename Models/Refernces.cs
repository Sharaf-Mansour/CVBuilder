namespace CVBuilder.Models;
public class Refernces : PersonalDataModel, ICloneable, IValidation
{
    public string? WorkPlace { get; set; }
     public string? JobTitle { get; set; }
    object ICloneable.Clone () => new Refernces () { Name = this.Name, Email = this.Email, Phone = this.Phone, JobTitle = this.JobTitle };
   // public override bool IsValid() => !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Phone) && !string.IsNullOrWhiteSpace(JobTitle) && !string.IsNullOrWhiteSpace(WorkPlace);
    public override bool IsValid() => new ReferncesValidator().Validate(this).IsValid;
}