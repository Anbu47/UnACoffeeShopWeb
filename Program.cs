using Microsoft.AspNetCore.Builder;
//using Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware;
//using Swashbuckle.AspNetCore.Swagger.ISwaggerProvider;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Builder.Extensions;

var builder = WebApplication.CreateBuilder(args);

var allowAnyPolicy = "allowAnyPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(allowAnyPolicy, policy => {
        policy.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();

    });
});
var pathToPrivateKey = "./unacoffeeshop-firebase-adminsdk-hd7r4-7ed881e393.json";
// Initialize Firebase Admin SDK
FirebaseApp.Create(new AppOptions
{
    Credential = GoogleCredential.FromFile(pathToPrivateKey)
});

// Initialize Firebase with the service account credentials
var firebaseClient = new FirebaseClient(
    "https://unacoffeeshop-default-rtdb.firebaseio.com/",
    new FirebaseOptions
    {
        AuthTokenAsyncFactory = () => Task.FromResult("j5EN7yNCXAwZT3jf1RIQnsWhq5c1xcQmwDofUrZg")
    });
builder.Services.AddSwaggerGen(); // add swagger to test out API
// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(allowAnyPolicy);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.UseSwagger();
app.UseSwaggerUI(options => { options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"); });
app.Run();
