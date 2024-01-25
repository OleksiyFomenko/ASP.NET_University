var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var myCompany = new Company
{
    Name = "Example Company",
    Location = "Some City",
    YearFounded = 2000
};

var random = new Random();

app.MapGet("/", () =>
{
    int randomNumber = random.Next(0, 101);

    // Повернення інформації про екземпляр класу Company
    //return $"{myCompany.Name} is located in {myCompany.Location} and was founded in {myCompany.YearFounded}.";

    // Повернення відповіді з випадковим числом
    return $"Random Number: {randomNumber}";
});

app.Run();

public class Company
{
    public string Name { get; set; }
    public string Location { get; set; }
    public int YearFounded { get; set; }
}
