using MovieInfoApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<MovieService>(); // Add this line

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // Defines the route for the default page of the application.
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Pages}/{action=Index}/{id?}");
});

// Runs the application. This is typically called after the middleware pipeline is configured.
app.Run();