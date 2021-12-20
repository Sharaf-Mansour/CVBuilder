namespace CVBuilder.Models;
public class Data : ICloneable, IValidation
{
    private bool isLink;
    public string? Value { get; set; }
    public bool IsLink { get => isLink; set => (isLink, Link) = (value, value ? Link : null); }
    public string? Link { get; set; }
    public virtual bool IsValid() => new DataValidator().Validate(this).IsValid;
    object ICloneable.Clone() => this.DeepClone();
    public bool InEditState { get; set; }
}
