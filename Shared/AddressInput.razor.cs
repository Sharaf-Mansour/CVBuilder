namespace CVBuilder.Shared;
using static CVBuilder.DateData;
public partial class AddressInput
{
    private static StateProvince[]? States(int? ID) => CountryStates?.FirstOrDefault(x => x.Country.Id == ID)?.StateProvince;
    [Parameter] public AddressModel? Address { get; set; } = new();
    public int? StateId { get => Address?.State?.Id; set => (Address!.State) = (States(Address?.Country?.Id)?.FirstOrDefault(x => x.Id == value)); }
    //public int? CountryId { get => Address?.Country?.Id; set => (StateId, Address!.Country) = (null, CountryStates?.FirstOrDefault(x=>x.Country.Id == value)?.Country); }
    [Parameter] public string? Id { get; set; }
    //protected override async Task OnInitializedAsync() => CountryStates = await Http.GetFromJsonAsync<CountryState[]>("CountryStateArray.json");
    //  string Valid => Address!.Country is null ? "is-invalid form-control" : "is-valid ";
}