namespace CVBuilder.Models;
public class PersonalDataModel :  IValidation
{
    [Required(ErrorMessage = "Name required.")]
    public string? Name {  get; set; }
    [Required(ErrorMessage = "Email required.")]
    public string? Email {  get; set; }
    [Required(ErrorMessage = "Phone required.")]
    public string? Phone {  get; set; }
    public string? Address { get; set; }
    public bool InEditState { get; set; }

    public bool IsValid() => true;

}