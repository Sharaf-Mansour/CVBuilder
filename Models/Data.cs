namespace CVBuilder.Models;

public class Data :ICloneable ,Validation
{
    public string? Value { get; set; }
   public bool IsVailid() => !string.IsNullOrWhiteSpace(Value);
   object ICloneable.Clone() => new Data() { Value = this.Value };

}