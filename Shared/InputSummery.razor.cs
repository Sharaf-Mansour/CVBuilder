 namespace CVBuilder.Shared;
public partial class InputSummery
{
    string[]? rows => PersonalDataModel?.Summary?.Split(Environment.NewLine.ToCharArray());
    int? maxLength => (rows?.Max(x => x.Length) > 100 || rows?.Length > 20 || PersonalDataModel?.Summary?.Length > 2000 ? PersonalDataModel?.Summary?.Length : 2000) ?? 0;
    [Parameter] public PersonalDataModel? PersonalDataModel { get; set; }
    [Parameter] public string? Id { get; set; }

}