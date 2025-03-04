var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.UseDefaultFiles();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}")
    .WithStaticAssets();

// On Production, we serve the compiled (built) version with Vite
// This file is a simple wrapper for markup that loads the Vite development server
app.MapFallbackToFile(app.Environment.IsDevelopment() ? "/index_dev.html" : "/client/index.html");

app.Run();
