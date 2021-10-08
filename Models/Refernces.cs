namespace CVBuilder.Models;
public class Refernces : PersonalDataModel, ICloneable ,Validation
{
    public string? WorkPlace {  get; set; }
    public string? JobTitle { get; set; }

     object ICloneable.Clone() => new Refernces() { Name = this.Name, Email = this.Email, Phone = this.Phone, JobTitle = this.JobTitle };

}