using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args: args);

//add services to application

var services = builder.Services;

services
	.AddEndpointsApiExplorer()
	.AddControllers();

var app = builder.Build();

//config http/https pipleline

if (builder.Environment.IsDevelopment())
	app.UseDeveloperExceptionPage();

app
	.UseHsts()
	.UseHttpsRedirection()
	.UseRouting()
	.UseSession();

app.MapControllers();

app.Run();