namespace CVBuilder.Models;
public class CV : IValidation
{
    public CVType CVtype { get; set; }
    public List<TabsModel> ListOfTabs { get; set; } = [
        new(Tabs.HomePage),new(Tabs.Personal),
        new(Tabs.Social),new( Tabs.Education),
        new(Tabs.WorkExperience),new(Tabs.OtherWorkExperience),
        new(Tabs.Skills),new(Tabs.Projects),
        new(Tabs.HobbiesAndInterests),new(Tabs.Certifications),
        new(Tabs.ProfessionalAffiliations),new(Tabs.References),
        new(Tabs.CV)
   ];
    public PersonalDataModel PersonalData { get; set; } = new();
    public List<Social>? Socials { get; set; } = [];
    public List<Education>? Educations { get; set; } = [];
    public List<Experience>? WorkExperience { get; set; } = [];
    public List<Experience>? OtherExperience { get; set; } = [];
    public List<Data>? Projects { get; set; } = [];
    public List<Certificate>? Certifications { get; set; } = [];
    public List<Data>? ProfessionalAffiliations { get; set; } = [];
    public List<References>? References { get; set; } = [];
    public List<Skill>? Skills { get; set; } = [];
    public List<Data>? HobbiesAndInterests { get; set; } = [];
    public bool InEditState { get; set; }
    public bool IsValid() => new CVValidator().Validate(this).IsValid;
}