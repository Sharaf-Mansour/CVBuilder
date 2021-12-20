namespace CVBuilder.Models;
public class PersonalDataModel
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public AddressModel Address { get; set; } = new();
}