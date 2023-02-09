namespace CVBuilder.Models;
public class CV : IValidation
{
    public CVType CVtype { get; set; }
    public List<TabsModel> ListOfTabs { get; set; } = new()
    {
        new() { Tab = Tabs.HomePage, IsSelected = true },
        new() { Tab = Tabs.Personal, IsSelected = true },
        new() { Tab = Tabs.Social, IsSelected = true },
        new() { Tab = Tabs.Education, IsSelected = true },
        new() { Tab = Tabs.WorkExperience, IsSelected = true },
        new() { Tab = Tabs.OtherWorkExperience, IsSelected = true },
        new() { Tab = Tabs.Skills, IsSelected = true },
        new() { Tab = Tabs.Projects, IsSelected = true },
        new() { Tab = Tabs.HobbiesAndInterests, IsSelected = true },
        new() { Tab = Tabs.Certifications, IsSelected = true },
        new() { Tab = Tabs.ProfessionalAffiliations, IsSelected = true },
        new() { Tab = Tabs.References, IsSelected = true },
        new() { Tab = Tabs.CV, IsSelected = true }
    };
    public PersonalDataModel PersonalData { get; set; } = new();
    public List<Social>? Socials { get; set; } = new();
    public List<Education>? Educations { get; set; } = new();
    public List<Experience>? WorkExperience { get; set; } = new();
    public List<Experience>? OtherExperience { get; set; } = new();
    public List<Data>? Projects { get; set; } = new();
    public List<Certificate>? Certifications { get; set; } = new();
    public List<Data>? ProfessionalAffiliations { get; set; } = new();
    public List<References>? References { get; set; } = new();
    public List<Skill>? Skills { get; set; } = new();
    public List<Data>? HobbiesAndInterests { get; set; } = new();
    public bool InEditState { get; set; }
    public bool IsValid() => new CVValidator().Validate(this).IsValid;
}