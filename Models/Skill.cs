namespace CVBuilder.Models;

public class Skill : IValidation
{
    public string? SkillType { get; set; }
    public List<Data>? Data { get; set; } = new();
    public bool InEditState { get; set; }
    public bool IsValid() => new SkillValidator().Validate(this).IsValid;
}