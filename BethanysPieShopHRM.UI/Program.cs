using BethanysPieShopHRM.UI.Data;
using BethanysPieShopHRM.UI.Interfaces;
using BethanysPieShopHRM.UI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net.Http;

var builder = WebApplication.CreateBuilder(args);
var apiBaseAddress = builder.Configuration["ApiBaseAddress"];

// Add services to the container.

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

builder.Services.AddScoped<HttpClient>(s =>
{
    var client = new HttpClient { BaseAddress = new System.Uri("https://localhost:44340/") };
    return client;
});

//services.AddScoped<IEmployeeDataService, MockEmployeeDataService>();
builder.Services.AddTransient<IEmployeeDataService, EmployeeDataService>();
builder.Services.AddTransient<ICountryDataService, CountryDataService>();
builder.Services.AddTransient<IJobCategoryDataService, JobCategoryDataService>();
builder.Services.AddTransient<IExpenseDataService, ExpenseDataService>();
builder.Services.AddTransient<ITaskDataService, TaskDataService>();
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddTransient<ISurveyDataService, SurveyDataService>();
builder.Services.AddTransient<IExpenseApprovalService, ManagerApprovalService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
