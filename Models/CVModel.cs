namespace CVBuilder.Models;
public class CVModel
    {
    #region "MetaData"
    public CVType CVtype { get; set; }
    #endregion
    #region "ModelData"
    public PersonalDataModel? PersonalData { get; init; } = new();
    public List<Education>? Educations { get; init; } = new();
    public List<Experience>? WorkExperience { get; init; } = new();
    public List<Experience>? OtherExperience { get; init; } = new();
    public List<string>? Certifications { get; init; } = new();
    public List<string>? ProfessionalAffeilations  { get; init; } = new();
    public List<Refernces>? refernces { get; init; } = new();
    #endregion
}