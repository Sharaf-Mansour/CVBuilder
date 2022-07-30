namespace CVBuilder.Models;

public class Social : IValidation
{
    public string? PlatformlName { get; set; }
    public Data? UserName { get; set; } = new();
    public bool InEditState { get; set; }
    public bool IsValid() => new SocialValidator().Validate(this).IsValid;
}