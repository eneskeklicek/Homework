var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", (context) =>
{
    context.Response.Redirect("/htmlpage.html");
    return Task.CompletedTask;
});

app.Run();
