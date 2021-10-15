
namespace CVBuilder.Models;
public class Data : ICloneable, IValidation {
    public string? Value { get; set; }
    public bool IsValid() => !string.IsNullOrWhiteSpace (Value);
    object ICloneable.Clone () => new Data () { Value = this.Value };
    public bool InEditState { get; set; }
}