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
    [ValidateComplexType]
    public PersonalDataModel? PersonalData { get; set; } = new ();
    [ValidateComplexType]
    public List<Education> ? Educations { get; set; } = new ();
    [ValidateComplexType]
    public List<Experience> ? WorkExperience { get; set; } = new ();
    [ValidateComplexType]
    public List<Experience> ? OtherExperience { get; set; } = new ();
    [ValidateComplexType]
    public List<Data> ? Certifications { get; set; } = new ();
    [ValidateComplexType]
    public List<Data> ? ProfessionalAffeilations { get; set; } = new ();
    [ValidateComplexType]
    public List<Data>? OpenSource { get; set; } = new();
    [ValidateComplexType]
    public List<Refernces> ? Refernces { get; set; } = new ();
    #endregion
}