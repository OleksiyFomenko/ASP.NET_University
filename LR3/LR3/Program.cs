
using System;
using ASP.NET.interfaces;
using ASP.NET.services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICalcService, CalcService>().AddTransient<ITimeAnalyzer, TimeAnalyzer>();
var app = builder.Build();
app.MapGet("/", async context => context.Response.Redirect("/1/"));
app.MapGet("/1/", async context =>
{
    var calcService = app.Services.GetService<ICalcService>();
    await context.Response.WriteAsync($"Result of addition: {calcService?.Add(4, 7)}\n");
    await context.Response.WriteAsync($"Result of multiplication: {calcService?.Multiply(3f, 5f)}\n");
    await context.Response.WriteAsync($"Result of subtraction: {calcService?.Subtract(4, 6)}\n");
    await context.Response.WriteAsync($"Result of division: {calcService?.Divide(15.0, 2.0)}\n");
});

app.MapGet("/2/", async context =>
{
    var dayTimeService = app.Services.GetService<ITimeAnalyzer>();
    await context.Response.WriteAsync($"Now {dayTimeService?.GetTimeOfDay(DateTime.Now)}\n");
});

app.Run();
