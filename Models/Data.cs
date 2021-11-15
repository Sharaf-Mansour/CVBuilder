namespace CVBuilder.Models;
public class Data : ICloneable, IValidation
{
    private bool isLink;
    public string? Value { get; set; }
    public bool IsLink { get => isLink; set=> (isLink,Link)= (value, value ? Link : null); }
    public string? Link { get; set; }
    public bool IsValid() =>  new DataValidator().Validate(this).IsValid;
    object ICloneable.Clone() => new Data() { Value = this.Value, IsLink =this.IsLink, Link = this.Link };
    public bool InEditState { get; set; }
}