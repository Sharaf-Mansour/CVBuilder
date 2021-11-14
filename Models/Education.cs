namespace CVBuilder.Models;
public class Education : ICloneable, IValidation
{
    public  string? LocationName { get; set; }
    public string? Year { get; set; }
    public List<Data>? Data { get; set; } = new();
   //public bool IsValid() => !string.IsNullOrWhiteSpace(LocationName) && !string.IsNullOrWhiteSpace(Year);
    public virtual bool IsValid() => new EducationValidator().Validate(this).IsValid;
    public bool InEditState { get; set; }
    object ICloneable.Clone() => new Education() { LocationName = this.LocationName, Year = this.Year, Data = this.Data }; 
}