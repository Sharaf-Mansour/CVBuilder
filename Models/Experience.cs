namespace CVBuilder.Models;
public class Experience : Education
{
    [Required(ErrorMessage = "Work Place Name required.")]
    public override string? LocationName { get; set; }
    [Required(ErrorMessage = "Job Title required.")]
    public string? JobTitle { get; set; }
   
}
