namespace CVBuilder.Models;
public class Education : ICloneable , Validation
{
    [Required(ErrorMessage = "School Name required.")]
    public virtual string? LocationName { get; set; }
    [Required(ErrorMessage = "Year required.")]
    public string? Year { get; set; }
    public List<Data>? Data { get; set; } = new();

    public bool IsVailid() => !string.IsNullOrWhiteSpace(LocationName) && !string.IsNullOrWhiteSpace(Year);


    // public Education Clone() => new() { LocationName = this.LocationName, Year = this.Year, Data = this.Data };

      object ICloneable.Clone() => new Education() { LocationName = this.LocationName, Year = this.Year, Data = this.Data };

 
}
