namespace CVBuilder.Models;
public class CV : IValidation
{
    public CVType CVtype { get; set; }
    public List<TabsModel> ListOfTabs { get; set; } = new()
    {
        new() { Tab = Tabs.HomePage, IsSelected = true },
        new() { Tab = Tabs.Personal, IsSelected = true },
        new() { Tab = Tabs.Education, IsSelected = true },
        new() { Tab = Tabs.WorkExprince, IsSelected = true },
        new() { Tab = Tabs.OtherWorkExprince, IsSelected = true },
        new() { Tab = Tabs.Projects, IsSelected = true },
        new() { Tab = Tabs.Certifications, IsSelected = true },
        new() { Tab = Tabs.ProfessionalAffeilations, IsSelected = true },
        new() { Tab = Tabs.Refernces, IsSelected = true },
        new() { Tab = Tabs.CV, IsSelected = true }
    };
    public PersonalDataModel PersonalData { get; set; } = new();
    public List<Education>? Educations { get; set; } = new();
    public List<Experience>? WorkExperience { get; set; } = new();
    public List<Experience>? OtherExperience { get; set; } = new();
    public List<DataLink>? Projects { get; set; } = new();
    public List<Certificate>? Certifications { get; set; } = new();
    public List<Data>? ProfessionalAffilations { get; set; } = new();
    public List<References>? Refernces { get; set; } = new();
    public bool InEditState { get; set; }
    public bool IsValid() => new CVValidator().Validate(this).IsValid;
}