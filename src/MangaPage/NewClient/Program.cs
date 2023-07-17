using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NewClient.Options;
using NewClient.Services;
using NewClient.Services.Mail;

var builder = WebApplication.CreateBuilder(args: args);

var services = builder.Services;

services.AddScoped<ComicService>();
services.AddScoped<ChapterImageService>();
services.AddScoped<UserService>();
services.AddScoped<JWTService>();
services.AddScoped<ISendMailService, SendMailService>();
services.ConfigureOptions<MailSettingsUpdate>();
services.AddHttpContextAccessor();

services
	.AddHttpClient(
		name: "MangaAPI",
		configureClient: httpClient =>
		{
			httpClient.BaseAddress = new(uriString: "https://localhost:7174/");
		});

services.AddRazorPages();

services.AddDataProtection();

services
	.AddDistributedMemoryCache()
	.AddSession(cfg =>
	{
		cfg.IdleTimeout = new(0, 60, 0);
		cfg.Cookie.Name = "authSession";
		cfg.Cookie.HttpOnly = false;
	});

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
	.UseRouting()
	.UseSession();

app.MapRazorPages();

app.Run();
