var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddBlazoredToast();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
await builder.Build().RunAsync();