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
