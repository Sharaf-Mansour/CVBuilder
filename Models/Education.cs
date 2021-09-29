namespace CVBuilder.Models;
public class Education
{
    [Required(ErrorMessage = "School Name required.")]
    public virtual string? LocationName { get; set; }
    [Required(ErrorMessage = "Year required.")]
    public string? Year { get; set; }
    public List<string>? Data { get; set; }
}