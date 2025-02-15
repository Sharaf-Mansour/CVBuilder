﻿namespace CVBuilder.ModelValidators;
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
        RuleForEach(x => x.References).SetValidator(new ReferncesValidator());
        RuleForEach(x => x.Certifications).SetValidator(new CertificateValidator());
        RuleForEach(x => x.Skills).SetValidator(new SkillValidator());
        RuleForEach(x => x.Socials).SetValidator(new SocialValidator());
        RuleForEach(x => x.HobbiesAndInterests).SetValidator(new DataValidator());
    }
}