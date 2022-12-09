using Microsoft.AspNetCore.Mvc;
using SampleNetCoreMVC.Controllers;
using SampleNetCoreMVC.Services;

var builder = WebApplication.CreateBuilder(args);
// This is the latest process to give the server the service to have controllers to serve views/webpages.

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IConsoleMailService, ConsoleMailService>();
var app = builder.Build();


// Process of serving base .html files without relying on MVC infrastructure

//DefaultFilesOptions defaultFileOption = new DefaultFilesOptions();
//defaultFileOption.DefaultFileNames.Clear();
//defaultFileOption.DefaultFileNames.Add("index.html");
//app.UseDefaultFiles(defaultFileOption);

app.UseStaticFiles();
app.UseRouting();


// This is a more modern and simplified approach to allow the backend to route incoming requests to different
// endpoints to get the resources needed for the desired response.

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=App}/{action=Index}/{id?}"
//    );

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Default", "/{controller}/{action}/{id?}", new { controller = "App", action = "Index" });
});

app.Run();