namespace CVBuilder.Models;
public class Refernces : PersonalDataModel, IValidation
{
    public string? WorkPlace { get; set; }
    public string? JobTitle { get; set; }
    public DataLink? Data { get; set; } = new();
    public override bool InEditState { get; set; }
    public override bool IsValid() => new ReferncesValidator().Validate(this).IsValid;
}