namespace CVBuilder.Models;
public class CV: IValidation {
  public CVType CVtype { get; set; }
    public PersonalDataModel PersonalData { get; set; } = new ();
    public List<Education> ? Educations { get; set; } = new ();
    public List<Experience> ? WorkExperience { get; set; } = new ();
    public List<Experience> ? OtherExperience { get; set; } = new ();
    public List<Data> ? Certifications { get; set; } = new ();
    public List<Data> ? ProfessionalAffeilations { get; set; } = new ();
    public List<Data>? OpenSource { get; set; } = new();
    public List<References > ? Refernces { get; set; } = new ();
    public bool InEditState { get; set; }
    public bool IsValid() => new CVValidator().Validate(this).IsValid;
}