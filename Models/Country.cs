namespace CVBuilder.Models;
public class Country
{
    private static Country? SetCountry(int value) => DateData.CountryStates?.FirstOrDefault(x => x.Country?.Id == value)?.Country;
    public int Id { get => field; set => (field, Name, TwoLetterIsoCode, ThreeLetterIsoCode) = (value, SetCountry(value)?.Name, SetCountry(value)?.TwoLetterIsoCode, SetCountry(value)?.ThreeLetterIsoCode); }
    public string? Name { get; set; }
    public string? TwoLetterIsoCode { get; set; }
    public string? ThreeLetterIsoCode { get; set; }
}