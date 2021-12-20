var builder = WebAssemblyHostBuilder.CreateDefault(args);
HttpClient HttpClient() => new() { BaseAddress = new(builder.HostEnvironment.BaseAddress) };
DateData.CountryStates = await HttpClient().GetFromJsonAsync<CountryState[]>("CountryStateArray.json") ?? throw new();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
await builder.Build().RunAsync();