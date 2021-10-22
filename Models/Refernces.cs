namespace CVBuilder.Models;
public class Refernces : PersonalDataModel, ICloneable, IValidation {
    [Required(ErrorMessage = "Please Enter The Work Place")]
    [StringLength(60, MinimumLength = 3, ErrorMessage = "Minimim length is 3 letter Maxmum Length is 40 letter")]
    public string? WorkPlace { get; set; }
    [Required(ErrorMessage = "Please Enter The Job Title")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Minimim length is 3 letter Maxmum Length is 40 letter")]
    public string? JobTitle { get; set; }
    object ICloneable.Clone () => new Refernces () { Name = this.Name, Email = this.Email, Phone = this.Phone, JobTitle = this.JobTitle };
}