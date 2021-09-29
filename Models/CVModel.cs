using System.ComponentModel.DataAnnotations;

namespace CVBuilder.Models;
    public class CVModel
    {


    #region "MetaData"
    //
    #endregion
    #region "ModelData"

    public PersonalDataModel? PersonalData { get; init; }


 

    // Full Name EN - Address - Mobile Phone - Work Phone - Personal Email - Work Email

    //Edu List of Model string Time Tital string and list<string>
    //Edu:Buss job des List of Model string Time Tital string and list<string>
    //
    #endregion
    //
}
public class PersonalDataModel
{
    [Required(ErrorMessage = "Name required.")]
    public string? Name {  get; set; }
    [Required(ErrorMessage = "Email required.")]
    public string? Email {  get; set; }
    [Required(ErrorMessage = "Phone required.")]
    public string? Phone {  get; set; }
    public string? Address { get; set; }
}
public class Education
{
    public string? LocationName { get; set; }
    public string? LocationName { get; set; }
    [Required(ErrorMessage = "Year required.")]
    public string? Year { get; set; }
    public List<string>? Data { get; set; }
}
public class Experience : Education
{

    public string? LocationName { get; set; }

    [Required(ErrorMessage = "School Name required.")]
    public string? SchoolName { get; set; }


}