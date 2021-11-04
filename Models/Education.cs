namespace CVBuilder.Models;
public class Education : ICloneable, IValidation
{
    [Required(ErrorMessage = "School Name required.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Minimim length is 3 letter Maxmum Length is 100 letter")]
    public virtual string? LocationName { get; set; }
    [Required(ErrorMessage = "Year required.")]
    [StringLength(30, MinimumLength = 4, ErrorMessage = "Minimim length is 4 letter Maxmum Length is 30 letter")]
    public string? Year { get; set; }
    [ValidateComplexType]
    public List<Data>? Data { get; set; } = new();
    public bool IsValid() => !string.IsNullOrWhiteSpace(LocationName) && !string.IsNullOrWhiteSpace(Year);
    public bool InEditState { get; set; }
    object ICloneable.Clone() => new Education() { LocationName = this.LocationName, Year = this.Year, Data = this.Data }; 
}