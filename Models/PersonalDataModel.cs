namespace CVBuilder.Models;
public class PersonalDataModel : IValidation
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public AddressModel Address { get; set; } = new();
    public DateTime? BirthDate { get; set; } = null;
    public MaritalStatus? MaritalStatus { get; set; } = null;
    public MilitaryStatus? MilitaryStatus { get; set; } = null;
    public string? Summery { get; set; } = null;
    public virtual bool InEditState { get; set; }
    public virtual bool IsValid() => new PersonValidator().Validate(this).IsValid;
}