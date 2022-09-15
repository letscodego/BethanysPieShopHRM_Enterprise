using BethanysPieShopHRM.UI.Data;
using BethanysPieShopHRM.UI.Interfaces;
using BethanysPieShopHRM.UI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);
var apiBaseAddress = builder.Configuration["ApiBaseAddress"];

// Add services to the container.

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

var pieShopURI = new Uri("https://localhost:44340/");
var recruitingURI = new Uri("https://localhost:5001/");

void RegisterTypedClient<TClient, TImplementation>(Uri apiBaseUrl)
    where TClient : class where TImplementation : class, TClient
{
    builder.Services.AddHttpClient<TClient, TImplementation>(client =>
    {
        client.BaseAddress = apiBaseUrl;
    });
}

// HTTP services
RegisterTypedClient<IEmployeeDataService, EmployeeDataService>(pieShopURI);
RegisterTypedClient<ICountryDataService, CountryDataService>(pieShopURI);
RegisterTypedClient<IJobCategoryDataService, JobCategoryDataService>(pieShopURI);
RegisterTypedClient<ITaskDataService, TaskDataService>(pieShopURI);
RegisterTypedClient<ISurveyDataService, SurveyDataService>(pieShopURI);
RegisterTypedClient<ICurrencyDataService, CurrencyDataService>(pieShopURI);
RegisterTypedClient<IExpenseDataService, ExpenseDataService>(pieShopURI);
RegisterTypedClient<IJobDataService, JobsDataService>(recruitingURI);

// Helper services
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
