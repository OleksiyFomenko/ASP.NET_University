using LR4;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var booksConfig = builder.Configuration.GetSection("Books").Get<List<BooksInfo>>();

builder.Configuration.AddJsonFile("Users.json");

var usersConfig = builder.Configuration.GetSection("Users").Get<List<UsersInfo>>();


app.MapGet("/", async context => context.Response.Redirect("/Library/"));
app.MapGet("/Library/", async context =>
{
    await context.Response.WriteAsync("Greetings!");
});

app.MapGet("/Library/Books", async context =>
{  
    foreach(var book in booksConfig)
    {
        await context.Response.WriteAsync($"{book.Name}\n");
    }
});

app.MapGet("/Library/Profile/{id?}", async context =>
{
    string idtsr = context.Request.RouteValues["id"] as string;
    int id = 0; 
    int.TryParse(idtsr, out id);

    if (id!=null)
    {
        await context.Response.WriteAsync($"Name: {usersConfig[id].Name}\n");
        await context.Response.WriteAsync($"Age: {usersConfig[id].Age}\n");
    }
    else
    {
        await context.Response.WriteAsync($"Name: {usersConfig[0].Name}\n");
        await context.Response.WriteAsync($"Age: {usersConfig[0].Age}\n");
    }
});


app.Run();
