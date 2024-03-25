var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute
    (
    name: "default",
    pattern: "",
    defaults: new { controller = "Main", action = "ProductOrder" }
    );
ProductValue.init();
app.Run();