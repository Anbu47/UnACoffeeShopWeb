using Microsoft.AspNetCore.Builder;
//using Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware;
//using Swashbuckle.AspNetCore.Swagger.ISwaggerProvider;
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
