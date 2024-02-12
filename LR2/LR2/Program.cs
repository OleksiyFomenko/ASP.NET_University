using LR2;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var companiesXml = builder.Configuration.GetSection("Companies").Get<List<CompanyInfo>>();
var companiesJson = builder.Configuration.GetSection("Companies").Get<List<CompanyInfo>>();
var companiesIni = builder.Configuration.GetSection("Companies").Get<List<CompanyInfo>>();

var userConfig = builder.Configuration.GetSection("UserConfig").Get<UserConfig>();


var maxEmployeesCompany = companiesXml
    .Concat(companiesJson)
    .Concat(companiesIni)
    .OrderByDescending(c => c.EmployeesCount)
    .FirstOrDefault();

app.MapGet("/", () => $"Company with the most employees: {maxEmployeesCompany?.Name}\n\n" +
$"User Info: {userConfig?.FirstName} {userConfig?.LastName}, Age: {userConfig?.Age}, Email: {userConfig?.Email}");

app.Run();
