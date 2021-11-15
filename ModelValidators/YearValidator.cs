namespace CVBuilder.Models;
public class DateValidator : AbstractValidator<DateModel>
{
    public DateValidator()
    {
        RuleFor(x => x.StartYear)
               .NotEmpty()
               .WithMessage("Must Enter Year");
        RuleFor(x => x.StartYear)
               .LessThanOrEqualTo(x => x.EndYear)
               .When(x => !x.NotFinished && x.EndYear is not null)
               .WithMessage("Start Date Can not be after the end date");
        RuleFor(x => x.EndYear)
               .GreaterThanOrEqualTo(x => x.StartYear)
               .When(x=> !x.NotFinished && x.EndYear is not null)
               .WithMessage("End Date Can not be Before the start date");
        RuleFor(x => (int?)x.StartMonth)
               .LessThanOrEqualTo(x => (int?)x.EndMonth)
               .When(x => x.StartYear is not null && x.StartYear >= x.EndYear && !x.NotFinished)
               .WithMessage("Start Date Can not be after the end date");
        RuleFor(x => (int?)x.EndMonth)
               .GreaterThanOrEqualTo(x => (int?)x.StartMonth)
               .When(x => x.EndYear is not null && x.StartYear >= x.EndYear && !x.NotFinished)
               .WithMessage("End Date Can not be Before the start date"); ;
    }
}