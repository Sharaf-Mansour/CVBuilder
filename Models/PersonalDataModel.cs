namespace CVBuilder.Models;
public class PersonalDataModel :  IValidation
{
    [Required(ErrorMessage = "Name required.")]
    [StringLength(40, MinimumLength = 3, ErrorMessage = "Minimim length is 3 letter Maxmum Length is 40 letter")]
    public string? Name {  get; set; }
    [Required(ErrorMessage = "Email required.")]
    [StringLength(50, ErrorMessage = "Not allowed for more than 50 Letter ")]
    [EmailAddress(ErrorMessage = "Format of mail is not correct")]
    public string? Email {  get; set; }
    [Required(ErrorMessage = "Phone required.")]
    [StringLength(15, ErrorMessage = " Maxmum Length is 15 Numbers")]
    [RegularExpression(@"^\+?\d+[0-9]$", ErrorMessage = "Phone Format is not supported.")]
    public string? Phone {  get; set; }
    public string? Address { get; set; }
    public bool InEditState { get; set; }

    public bool IsValid() => true;

}