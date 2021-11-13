using FluentValidation;

namespace CVBuilder.Models;
public static class CVModel {
  public static CV CV { get; set; } = new ();
   public static List<TabsModel> Tabs { get; set; } = new() { new(CVBuilder.Tabs.Personal) { IsSelected = true}, new(CVBuilder.Tabs.Education) { IsSelected = true },
       new(CVBuilder.Tabs.WorkExprince) { IsSelected = true }, new(CVBuilder.Tabs.OtherWorkExprince) { IsSelected = true }, new(CVBuilder.Tabs.Certifications) { IsSelected = true },
       new(CVBuilder.Tabs.ProfessionalAffeilations) { IsSelected = true }, new(CVBuilder.Tabs.Refernces) { IsSelected = true }, new(CVBuilder.Tabs.CV) { IsSelected = true }};

}
public class CV {
  #region "MetaData"
  public CVType CVtype { get; set; }
    #endregion
    #region "ModelData"
    public PersonalDataModel? PersonalData { get; set; } = new ();

    public List<Education> ? Educations { get; set; } = new ();

    public List<Experience> ? WorkExperience { get; set; } = new ();

    public List<Experience> ? OtherExperience { get; set; } = new ();

    public List<Data> ? Certifications { get; set; } = new ();

    public List<Data> ? ProfessionalAffeilations { get; set; } = new ();

    public List<Data>? OpenSource { get; set; } = new();

    public List<Refernces> ? Refernces { get; set; } = new ();
    #endregion
}

public class CVValidator : AbstractValidator<CV>
{
    public CVValidator()
    {
        RuleFor(x => x.PersonalData).SetValidator(new PersonValidator());
        RuleForEach(x => x.Educations).SetValidator(new EducationValidator());
        RuleForEach(x => x.WorkExperience).SetValidator(new ExperienceValidator());
        RuleForEach(x => x.OtherExperience).SetValidator(new ExperienceValidator());
        RuleForEach(x => x.Refernces).SetValidator(new ReferncesValidator());

    }
}

