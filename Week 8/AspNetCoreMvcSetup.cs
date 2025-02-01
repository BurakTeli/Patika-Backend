using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adding MVC Services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Enabling Static Files Usage
app.UseStaticFiles();

// Configuring Routing
app.UseRouting();

// Default Routing Configuration
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();

/*
Controller: Handles user requests and returns appropriate responses.
Action: A method inside a Controller that processes a specific request.
Model: Defines the data structures used in the application.
View: Represents the user interface to be displayed.
Razor: A view engine used in ASP.NET Core for dynamic content rendering.
RazorView: The HTML pages processed and rendered by the Razor engine.
wwwroot: A folder containing static files (CSS, JavaScript, images, etc.).

builder.Build(): Creates and configures the required objects for the application.
app.Run(): Starts the application and begins listening for incoming HTTP requests.
*/
