namespace CVBuilder.Models;
public class Education : ICloneable , IValidation
{
    [Required(ErrorMessage = "School Name required.")]
    public virtual string? LocationName { get; set; }
    [Required(ErrorMessage = "Year required.")]
    public string? Year { get; set; }
    public List<Data>? Data { get; set; } = new();
    public bool IsValid() => !string.IsNullOrWhiteSpace(LocationName) && !string.IsNullOrWhiteSpace(Year);
    public bool InEditState { get; set; }
    object ICloneable.Clone() => new Education() { LocationName = this.LocationName, Year = this.Year, Data = this.Data }; 
}
