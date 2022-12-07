var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

DefaultFilesOptions defaultFileOption = new DefaultFilesOptions();
defaultFileOption.DefaultFileNames.Clear();
defaultFileOption.DefaultFileNames.Add("index.html");
app.UseDefaultFiles(defaultFileOption);
app.UseStaticFiles();


app.Run();