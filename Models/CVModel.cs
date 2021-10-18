namespace CVBuilder.Models;

public static class CVModel {
  public static CV CV { get; set; } = new ();


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