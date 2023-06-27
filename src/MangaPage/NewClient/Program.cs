using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NewClient.Services;

var builder = WebApplication.CreateBuilder(args: args);

var services = builder.Services;

services.AddScoped<ComicService>();
services.AddScoped<ChapterImageService>();

services
	.AddHttpClient(
		name: "MangaAPI",
		configureClient: httpClient =>
		{
			httpClient.BaseAddress = new(uriString: "https://localhost:7174/");
		});

services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}

app
	.UseExceptionHandler(errorHandlingPath: "/Error")
	.UseHsts()
	.UseHttpsRedirection()
	.UseStaticFiles()
	.UseRouting();

app.MapRazorPages();

app.Run();
