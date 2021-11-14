namespace CVBuilder.Models;
public class PersonalDataModel : IValidation
{
    public string? Name {  get; set; }
    public string? Email {  get; set; }
   // [RegularExpression(@"^\+?\d+[0-9]$", ErrorMessage = "Phone Format is not supported.")]
    public string? Phone {  get; set; }
    public string? Address { get; set; }
    public bool InEditState { get; set; }
    public virtual bool IsValid() => new PersonValidator().Validate(this).IsValid;
}