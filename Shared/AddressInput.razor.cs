namespace CVBuilder.Shared;
using static CVBuilder.DateData;
public partial class AddressInput
{
    private static StateProvince[]? States(int? ID) => CountryStates?.FirstOrDefault(x => x.Country?.Id == ID)?.StateProvince;
    [Parameter] public AddressModel? Address { get; set; } = new();
    public int? StateId
    {
        get => Address?.State?.Id;
        set => (Address!.State) = (States(Address?.Country?.Id)?.FirstOrDefault(x => x.Id == value));
    }
    [Parameter] public string? Id { get; set; }
}