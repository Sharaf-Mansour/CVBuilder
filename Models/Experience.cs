namespace CVBuilder.Models;
public class Experience : Education, ICloneable,IValidation
{
    [Required(ErrorMessage = "Work Place Name required.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Minimim length is 3 letter Maxmum Length is 50 letter")]
    public override string? LocationName { get; set; }
    [Required(ErrorMessage = "Job Title required.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Minimim length is 3 letter Maxmum Length is 50 letter")]
    public string? JobTitle { get; set; }
    object ICloneable.Clone() => new Experience() { LocationName = this.LocationName, Year = this.Year, Data = this.Data,JobTitle = this.JobTitle };

}
