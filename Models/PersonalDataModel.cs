﻿namespace CVBuilder.Models;
public class PersonalDataModel : IValidation
{
    public string? Name {  get; set; }
    public string? Email {  get; set; }
     public string? Phone {  get; set; }
    public string? Address { get; set; }
    public bool InEditState { get; set; }
    public virtual bool IsValid() => new PersonValidator().Validate(this).IsValid;
}