namespace CVBuilder.Models;
public class PersonalDataModel : IValidation
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public AddressModel Address { get; set; } = new();
    public virtual bool InEditState { get; set; }
    public virtual bool IsValid() => new PersonValidator().Validate(this).IsValid;
}