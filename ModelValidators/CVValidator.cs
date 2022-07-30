namespace CVBuilder.ModelsValidators;
public class CVValidator : AbstractValidator<CV>
{
    public CVValidator()
    {
        RuleFor(x => x.PersonalData).SetValidator(new PersonValidator());
        RuleForEach(x => x.Educations).SetValidator(new EducationValidator());
        RuleForEach(x => x.WorkExperience).SetValidator(new ExperienceValidator());
        RuleForEach(x => x.OtherExperience).SetValidator(new ExperienceValidator());
        RuleForEach(x => x.Projects).SetValidator(new DataValidator());
        RuleForEach(x => x.ProfessionalAffiliations).SetValidator(new DataValidator());
        RuleForEach(x => x.Refernces).SetValidator(new ReferncesValidator());
        RuleForEach(x => x.Certifications).SetValidator(new CertificateValidator());
        RuleForEach(x => x.Skills).SetValidator(new SkillValidator());
        RuleForEach(x => x.Socials).SetValidator(new SocialValidator());
        // RuleFor(x => x).Must(X => !CRUD.IsInEditState);
    }
}