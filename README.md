# PROJETO USANDO VIEWS
Projeto web utilizando a tecnologia ASPNET a partir de um projeto web vazio.

## Definições do Projeto
- Adicionar o Runtime Compilation do Razor.

```
dotnet add package Microsoft.AspNETCore.Mvc.Razor.RunTimeCompilation
```

- Adicionar ao projeto a capacidade de trabalhar com views e utilizar o runtime rompilation do razor.

- Adicione o código abaixo no arquivo Program.cs

```
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

```

- Adicionar as referências para utilização de Controller e View no arquivo Program.cs
```
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
```
- Adicionar a ferramenta libman
```
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
```

- Adicionar, através do `libman`, a referência para utilizar bibliotecas externas ao projeto.
```
libman init -p jsdelivr
```

- Instalar a versão mais recente do `bootstrap` ao projeto
```
libman install bootstrap -d wwwroot/lib/bootstrap5
```

- Adicionar a referência do `bootstrap` às views
```
<link rel="stylesheet" href="/lib/bootstrap5/dist/css/bootstrap.css">
```

