var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
	// Permite criar uma rota personalizada
	// endpoints.MapControllerRoute("Default", 
	// "{controller=Home}/{action=Index}/{}id?");

	// Define a rota padrão como a rota utilizada 
	// "{controller=Home}/{action=Index}/{}id?"
	endpoints.MapDefaultControllerRoute();
});

app.Run();
