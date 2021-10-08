namespace CVBuilder.Models;
public class Experience : Education, ICloneable,Validation
{
    [Required(ErrorMessage = "Work Place Name required.")]
    public override string? LocationName { get; set; }
    [Required(ErrorMessage = "Job Title required.")]
    public string? JobTitle { get; set; }
    object ICloneable.Clone() => new Experience() { LocationName = this.LocationName, Year = this.Year, Data = this.Data,JobTitle = this.JobTitle };

}
