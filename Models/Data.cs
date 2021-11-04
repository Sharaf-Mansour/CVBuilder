
namespace CVBuilder.Models;
public class Data : ICloneable, IValidation
{
    private bool isLink;
    private string? link;
    public string? Value { get; set; }
    public bool IsLink { get => isLink; set=> (isLink,Link)= (value, value ? Link : null); }
    [Url(ErrorMessage = "Link is not in the correct format Try starting with Http:// or Https://")]
    public string? Link { get => link; set => link= string.IsNullOrWhiteSpace(value) ? null:value; }
    public bool IsValid() => !string.IsNullOrWhiteSpace(Value) && (!IsLink ||!string.IsNullOrWhiteSpace(Link));
    object ICloneable.Clone() => new Data() { Value = this.Value, IsLink =this.IsLink, Link = this.Link };
    public bool InEditState { get; set; }
}
