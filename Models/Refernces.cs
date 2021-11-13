namespace CVBuilder.Models;
public class Refernces : PersonalDataModel, ICloneable, IValidation
{
    public string? WorkPlace { get; set; }
     public string? JobTitle { get; set; }
    object ICloneable.Clone () => new Refernces () { Name = this.Name, Email = this.Email, Phone = this.Phone, JobTitle = this.JobTitle };
    public override bool IsValid() => !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Phone) && !string.IsNullOrWhiteSpace(JobTitle) && !string.IsNullOrWhiteSpace(WorkPlace);
}

public class ReferncesValidator : AbstractValidator<Refernces>
{
    public ReferncesValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name required.")
            .MaximumLength(40).WithMessage("Maxmum Length is 40 letter");
        RuleFor(x => x.WorkPlace).NotEmpty().WithMessage("Please Enter The Work Place")
            .MaximumLength(40).WithMessage("Maxmum Length is 40 letter");
        RuleFor(x => x.JobTitle).NotEmpty().WithMessage("Please Enter The Job Title")
            .MaximumLength(40).WithMessage("Maxmum Length is 40 letter");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email required.")
            .MaximumLength(40).WithMessage("Not allowed for more than 40 Letter ")
            .EmailAddress().WithMessage("Format of mail is not correct");
        RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is required")
            .MaximumLength(15).WithMessage("Max Length is 15 number");
    }
}