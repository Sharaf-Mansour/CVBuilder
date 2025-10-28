namespace CVBuilder.Models;
public class Data : IValidation
{
    public string? Value { get; set; }
    public bool IsLink { get => field; set => (field, Link) = (value, value ? Link : null); }
    public string? Link { get; set; }
    public virtual bool IsValid() => new DataValidator().Validate(this).IsValid;
    public bool InEditState { get; set; }
}