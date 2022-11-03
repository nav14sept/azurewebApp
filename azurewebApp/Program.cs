using azurewebApp.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "Endpoint=https://az204app-config.azconfig.io;Id=S9jz-l4-s0:fY1sLbnhGN6R6IrD0nIN;Secret=0PsOFUsI0Zz7m0NMGqiVVFPOBFrQ7PirFj2gu8GAMkU=";

builder.Host.ConfigureAppConfiguration(builder =>
{
    builder.AddAzureAppConfiguration(connectionString);
}
);


builder.Services.AddTransient<IProductService, ProductService>();

builder.Services.AddRazorPages();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
