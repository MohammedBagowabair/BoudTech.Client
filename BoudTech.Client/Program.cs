var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); //  serves index.html by default
app.UseStaticFiles();  //  serves CSS, JS, images

app.Run();


