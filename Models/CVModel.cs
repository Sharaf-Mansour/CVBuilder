
namespace CVBuilder.Models;
public static class CVModel 
{
    public static CV CV { get; set; } = new();
  }
public  class CV
{
    #region "MetaData"
    public  CVType CVtype { get; set; }
    #endregion
    #region "ModelData"
    public  PersonalDataModel? PersonalData { get; set; } = new();
    public  List<Education>? Educations { get; set; } = new List<Education>();
    public  List<Experience>? WorkExperience { get; set; } = new();
    public  List<Experience>? OtherExperience { get; set; } = new();
    public  List<Data>? Certifications { get; set; } = new();
    public  List<Data>?  ProfessionalAffeilations { get; set; } = new();
    public  List<Refernces>? Refernces { get; set; } = new();
    #endregion
}