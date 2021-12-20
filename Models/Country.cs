namespace CVBuilder.Models;
public class Country
{
    private int id;
    private Country? _(int value) => DateData.CountryStates?.FirstOrDefault(x => x.Country.Id == value)?.Country;
    public int Id { get => id; set => (id, Name, TwoLetterIsoCode, ThreeLetterIsoCode) = (value, _(value)?.Name, _(value)?.TwoLetterIsoCode, _(value)?.ThreeLetterIsoCode); }
    public string? Name { get; set; }
    public string? TwoLetterIsoCode { get; set; }
    public string? ThreeLetterIsoCode { get; set; }
}