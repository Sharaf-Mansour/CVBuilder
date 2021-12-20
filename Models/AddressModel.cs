namespace CVBuilder.Models;
public class AddressModel : IValidation, ICloneable
{
    public StateProvince? State { get; set; }
    public Country? Country { get; set; } = new();
    public string? Street { get; set; }
    public string? ZIPCode { get; set; }
    public bool InEditState { get; set; }
    public bool IsValid() => new AddressValidator().Validate(this).IsValid;
    object ICloneable.Clone() => this.DeepClone();
    public string FullAddress() => @$"{(string.IsNullOrWhiteSpace(Street) ? "" : $"{Street}, ")}{(State is null ? " " : $"{State.Name}, ")}{(Country is null ? " " : $"{Country.Name} {Country.TwoLetterIsoCode} ")}{(string.IsNullOrWhiteSpace(ZIPCode) ? "" : $"{ZIPCode}")}";
}